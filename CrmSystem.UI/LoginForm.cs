using CrmSystem.BL.Model;
using System;
using System.Windows.Forms;

namespace CrmSystem.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        public Customer Customer { get; private set; }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            Customer = new Customer()
            {
                Name = NameTextBox.Text
            };

            Close();
        }
    }
}
