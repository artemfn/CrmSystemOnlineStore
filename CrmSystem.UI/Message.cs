using System.Windows.Forms;

namespace CrmSystem.UI
{
    public struct Message
    {
        private const string NOSALLERSMESSAGE = "Unfortunately, there are no sellers at the moment, we will not be able to serve you.";
        private const string FILLCARTMESSAGE = "To make a buy, you need to fill the cart.";
        private const string LOGINMESSAGE = "To make a buy, you need to log in.";
        private const string PAYMENTTITTLE = "Payment";


        public static string FullPriceMessage => "Full price: ";


        public static DialogResult Show(MessageType type)
        {
            if (type == MessageType.NoSellers)
                return MessageBox.Show(NOSALLERSMESSAGE, PAYMENTTITTLE, MessageBoxButtons.OK, MessageBoxIcon.Information);

            else if (type == MessageType.FillCart)
                return MessageBox.Show(FILLCARTMESSAGE, PAYMENTTITTLE, MessageBoxButtons.OK, MessageBoxIcon.Information);

            else if (type == MessageType.LogIn)
                return MessageBox.Show(LOGINMESSAGE, PAYMENTTITTLE, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            else
                return default;
        }
    }
}