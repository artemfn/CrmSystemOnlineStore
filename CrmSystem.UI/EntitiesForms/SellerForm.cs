using CrmSystem.BL.Model;
using System;
using System.Windows.Forms;

namespace CrmSystem.UI.AddForms
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }


        public Seller Seller { get; private set; }


        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                DialogResult = DialogResult.Cancel;

            Seller = new Seller()
            {
                Name = NameTextBox.Text
            };

            Close();
        }
    }
}