using CrmSystem.BL.Model;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace CrmSystem.UI
{
    public class CashDeskView
    {
        private readonly int _spaceLength = 10;
        private readonly int _generalHeight = 20;
        private readonly int _cashDeskNameLabelWidth = 80;
        private readonly int _leavedCustomerLabelWidth = 20;
        private readonly int _earnedPriceNumericWidth = 220;
        private readonly int _queueCountProgressBarWidth = 120;

        private readonly CashDesk _cashDesk;


        public CashDeskView(CashDesk cashDesk, int positionX, int positionY)
        {
            _cashDesk = cashDesk ??
                throw new ArgumentNullException(nameof(cashDesk));

            CashDeskName = new Label();
            EarnedPrice = new NumericUpDown();
            QueueCount = new ProgressBar();
            LeavedCustomers = new Label();

            InitializeComponent(_cashDesk, positionX, positionY);

            _cashDesk.CheckClosed += OnCheckClosed;
        }


        public Label CashDeskName { get; private set; }
        public NumericUpDown EarnedPrice { get; private set; }
        public ProgressBar QueueCount { get; private set; }
        public Label LeavedCustomers { get; private set; }


        private void OnCheckClosed(object sender, Check e)
        {
            EarnedPrice.Invoke((Action)delegate
            {
                EarnedPrice.Value += e.FullPrice;
                QueueCount.Value = _cashDesk.QueueCount;
                LeavedCustomers.Text = _cashDesk.LeavedCustomers.ToString();
            });
        }

        private void InitializeComponent(CashDesk cashDesk, int positionX, int positionY)
        {
            CashDeskName.Location = new Point(positionX, positionY);
            CashDeskName.Size = new Size(_cashDeskNameLabelWidth, _generalHeight);
            CashDeskName.TextAlign = ContentAlignment.MiddleLeft;
            CashDeskName.Text = _cashDesk.ToString();
            CashDeskName.Name = "CashDeskNameLabel" + cashDesk.ToString();


            EarnedPrice.Location = new Point(positionX + _cashDeskNameLabelWidth + _spaceLength, positionY);
            EarnedPrice.Size = new Size(_earnedPriceNumericWidth, _generalHeight);
            EarnedPrice.Name = " EarnedPriceNumeric" + cashDesk.ToString();
            EarnedPrice.Maximum = decimal.MaxValue;


            QueueCount.Location = new Point(positionX + _cashDeskNameLabelWidth + _earnedPriceNumericWidth + _spaceLength * 2, positionY);
            QueueCount.Size = new Size(_queueCountProgressBarWidth, _generalHeight);
            QueueCount.Name = "QueueCountProgressBar" + cashDesk.ToString();
            QueueCount.Maximum = cashDesk.MaxQueueLength;
            QueueCount.Value = 0;


            LeavedCustomers.Location = new Point(positionX + _cashDeskNameLabelWidth + _earnedPriceNumericWidth + _queueCountProgressBarWidth + _spaceLength * 3, positionY);
            LeavedCustomers.Size = new Size(_leavedCustomerLabelWidth, _generalHeight);
            LeavedCustomers.TextAlign = ContentAlignment.MiddleLeft;
            LeavedCustomers.Text = "0";
            LeavedCustomers.Name = "LeavedCustomersLabel" + cashDesk.ToString();
        }
    }
}