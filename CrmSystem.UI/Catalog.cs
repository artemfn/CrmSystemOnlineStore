using CrmSystem.BL.Data;
using CrmSystem.BL.Model;
using CrmSystem.UI.AddForms;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace CrmSystem.UI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        private readonly Type _type = typeof(T);

        private readonly CrmContext _context;
        private readonly DbSet<T> _set;

        private ProductForm _productForm;
        private CustomerForm _customerForm;
        private SellerForm _sellerForm;


        public Catalog(CrmContext context, DbSet<T> set)
        {
            InitializeComponent();

            set.Load();
            _set = set;
            _context = context;
            DataGridView.DataSource = _set.Local.ToBindingList();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            _productForm = new ProductForm();
            _customerForm = new CustomerForm();
            _sellerForm = new SellerForm();


            if (_type == typeof(Product))
            {
                if (_productForm.ShowDialog() == DialogResult.OK)
                    _context.Products.Add(_productForm.Product);
            }

            else if (_type == typeof(Customer))
            {
                if (_customerForm.ShowDialog() == DialogResult.OK)
                    _context.Customers.Add(_customerForm.Customer);
            }

            else if (_type == typeof(Seller))
            {
                if (_sellerForm.ShowDialog() == DialogResult.OK)
                    _context.Sellers.Add(_sellerForm.Seller);
            }

            _context.SaveChangesAsync();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var id = DataGridView.SelectedRows[0].Cells[0].Value;


            if (_type == typeof(Product))
                _context.Products.Remove(_set.Find(id) as Product);

            else if (_type == typeof(Customer))
                _context.Customers.Remove(_set.Find(id) as Customer);

            else if (_type == typeof(Seller))
                _context.Sellers.Remove(_set.Find(id) as Seller);

            else if (_type == typeof(Check))
                _context.Checks.Remove(_set.Find(id) as Check);

            else if (_type == typeof(Sell))
                _context.Sells.Remove(_set.Find(id) as Sell);

            _context.SaveChangesAsync();
        }
    }
}