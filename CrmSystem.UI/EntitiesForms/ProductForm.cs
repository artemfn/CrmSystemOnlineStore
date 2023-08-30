using CrmSystem.BL.Model;
using System;
using System.Windows.Forms;

namespace CrmSystem.UI.AddForms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }


        public Product Product { get; private set; }


        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) &&
                string.IsNullOrWhiteSpace(PriceNumeric.Text) &&
                string.IsNullOrWhiteSpace(CountNumeric.Text))
                DialogResult = DialogResult.Cancel;

            Product = new Product()
            {
                Name = NameTextBox.Text,
                Price = PriceNumeric.Value,
                Count = (int)CountNumeric.Value
            };

            Close();
        }
    }
}