using CrmSystem.BL.Model;
using System;
using System.Windows.Forms;

namespace CrmSystem.UI.AddForms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }


        public Customer Customer { get; private set; }


        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                DialogResult = DialogResult.Cancel;

            Customer = new Customer()
            {
                Name = NameTextBox.Text
            };

            Close();
        }
    }
}