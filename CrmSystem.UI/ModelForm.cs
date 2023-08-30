using CrmSystem.BL.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrmSystem.UI
{
    public partial class ModelForm : Form
    {
        private readonly int _spaceLength = 10;
        private readonly int _heightCoefficient = 26;

        private readonly ComputerModel _model;


        public ModelForm()
        {
            InitializeComponent();

            _model = new ComputerModel();
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            var cashDesksView = new List<CashDeskView>();

            for (int i = 0; i < _model.CashDesks.Count; i++)
            {
                var view = new CashDeskView(_model.CashDesks[i], _spaceLength, _heightCoefficient * i + _spaceLength);

                cashDesksView.Add(view);

                Controls.Add(view.CashDeskName);
                Controls.Add(view.EarnedPrice);
                Controls.Add(view.QueueCount);
                Controls.Add(view.LeavedCustomers);
            }

            _model.Start();
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            _model.Stop();
        }

        private void ModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _model.Stop();
        }

        private void ModelForm_Load(object sender, EventArgs e)
        {
            CustomersProgressingSpeedNumeric.Value = _model.CustomersProgressingSpeed;
            CashDesksProgressingSpeedNumeric.Value = _model.CashDesksProgressingSpeed;
        }

        private void CustomersProgressingSpeedNumeric_ValueChanged(object sender, EventArgs e)
        {
            _model.CustomersProgressingSpeed = (int)CustomersProgressingSpeedNumeric.Value;
        }

        private void CashDesksProgressingSpeedNumeric_ValueChanged(object sender, EventArgs e)
        {
            _model.CashDesksProgressingSpeed = (int)CashDesksProgressingSpeedNumeric.Value;
        }
    }
}