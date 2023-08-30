using CrmSystem.BL.Data;
using CrmSystem.BL.Model;
using CrmSystem.UI.AddForms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmSystem.UI
{
    public partial class MainForm : Form
    {
        private readonly CrmContext _context;
        private readonly CashDesk _cashDesk;

        private Customer _customer;
        private Cart _cart;

        private bool _isRegistered;


        public MainForm()
        {
            InitializeComponent();

            _context = new CrmContext();
            _cashDesk = new CashDesk(1, GetRandomSeller(), _context);
            _customer = new Customer();
            _cart = new Cart(_customer);
            _cashDesk.IsComputerModel = false;
            _isRegistered = false;
        }


        private Seller GetRandomSeller()
        {
            if (_context.Sellers.Count() > 0)
            {
                var idList = new List<int>();

                foreach (var seller in _context.Sellers)
                {
                    idList.Add(seller.SellerId);
                }

                var index = new Random().Next(0, idList.Count);
                var sellerId = idList[index];

                return _context.Sellers.SingleOrDefault(s => s.SellerId == sellerId);
            }

            return null;
        }
        private void Add<T>(T item)
            where T : class
        {
            if (item is ProductForm productForm)
            {
                if (productForm.ShowDialog() == DialogResult.OK)
                    _context.Products.Add(productForm.Product);
            }

            else if (item is CustomerForm customerForm)
            {
                if (customerForm.ShowDialog() == DialogResult.OK)
                    _context.Customers.Add(customerForm.Customer);
            }

            else if (item is SellerForm sellerForm)
            {
                if (sellerForm.ShowDialog() == DialogResult.OK)
                    _context.Sellers.Add(sellerForm.Seller);
            }

            _context.SaveChangesAsync();
        }
        private void Show<T>(DbSet<T> set)
            where T : class
        {
            var catalog = new Catalog<T>(_context, set);
            catalog.Show();
        }


        private void ProductsMenuItem_Click(object sender, EventArgs e)
            => Show(_context.Products);

        private void CustomersMenuItem_Click(object sender, EventArgs e)
            => Show(_context.Customers);

        private void SellersMenuItem_Click(object sender, EventArgs e)
            => Show(_context.Sellers);

        private void ChecksMenuItem_Click(object sender, EventArgs e)
            => Show(_context.Checks);

        private void SellsMenuItem_Click(object sender, EventArgs e)
            => Show(_context.Sells);


        private void ProductsAddMenuItem_Click(object sender, EventArgs e)
            => Add(new ProductForm());

        private void CustomersAddMenuItem_Click(object sender, EventArgs e)
            => Add(new CustomerForm());

        private void SellersAddMenuItem_Click(object sender, EventArgs e)
            => Add(new SellerForm());


        private void ModelMenu_Click(object sender, EventArgs e)
            => new ModelForm().Show();


        private void MainForm_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                ProductsListBox.Invoke((Action)delegate
                {
                    ProductsListBox.Items.Clear();
                    ProductsListBox.Items.AddRange(_context.Products.ToArray());
                });
            });
        }


        private void ProductsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (ProductsListBox.SelectedItem is Product product)
            {
                _cart.Add(product);
                CartListBox.Items.Add(product);
                FullPriceLabel.Text = $"{Message.FullPriceMessage} {_cart.FullPrice}";
            }
        }

        private void CartListBox_DoubleClick(object sender, EventArgs e)
        {
            if (ProductsListBox.SelectedItem is Product product)
            {
                _cart.Remove(product);
                CartListBox.Items.Remove(product);
                FullPriceLabel.Text = $"{Message.FullPriceMessage} {_cart.FullPrice}";
            }
        }


        private void LoginLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new LoginForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var customer = _context.Customers.FirstOrDefault(c => c.Name.Equals(form.Customer.Name));

                if (customer != null)
                {
                    _customer = customer;
                }
                else
                {
                    _context.Customers.Add(form.Customer);
                    _context.SaveChangesAsync();
                    _customer = form.Customer;
                }

                _cart.Customer = _customer;

                _isRegistered = true;
                LoginLinkedLabel.Text = _customer.Name;
            }
        }


        private void PayButton_Click(object sender, EventArgs e)
        {
            if (_context.Sellers.Count() <= 0)
            {
                Message.Show(MessageType.NoSellers);
                return;
            }

            if (CartListBox.Items.Count <= 0)
            {
                Message.Show(MessageType.FillCart);
                return;
            }

            if (_isRegistered)
            {
                _cashDesk.Enqueue(_cart);
                _cashDesk.Dequeue();
                _cart = new Cart(_customer);

                CartListBox.Items.Clear();
                FullPriceLabel.Text = $"{Message.FullPriceMessage} 0";
            }
            else
            {
                if (Message.Show(MessageType.LogIn) == DialogResult.Yes)
                {
                    LoginLinkedLabel_LinkClicked(sender, null);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            MainForm_Load(sender, e);
        }
    }
}