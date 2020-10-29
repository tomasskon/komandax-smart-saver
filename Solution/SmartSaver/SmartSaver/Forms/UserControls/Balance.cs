using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SmartSaver.Domain.Repositories;
using SmartSaver.Logic.HelperClasses.Balance;
using SmartSaver.Domain.Models;

namespace SmartSaver.Forms.UserControls
{
    public partial class Balance : UserControl
    {
        public Balance()
        {
            InitializeComponent();
            UpdateIfExist();
        }
        private void Enter_Click(object sender, System.EventArgs e)
        {
            InputBox.ForeColor = Color.Black;
            DataValidation dv = new DataValidation();
            var helper = new BalanceHelper(new BalanceRepository());

            if (dv.ValidateMoneyInput(InputBox.Text))
            {
                switch (InputComboBox.SelectedIndex)
                {
                    case 0:
                        helper.AddCashToDb(InputBox.Text);
                        break;
                    case 1:
                        helper.AddCardToDb(InputBox.Text);
                        break;
                }
                UpdateIfExist();
            }
            else
                InputBox.ForeColor = Color.Red;
        }
        private async void UpdateIfExist()
        {
            /*
            MoneyFormatter mf = new MoneyFormatter();
            var repository = new BalanceRepository();
            var helper = new BalanceHelper(repository);
            var userBalance = await repository.GetBalanceIfExist(Domain.Constants.Constants.TestUserId);
            CashBox.Text = mf.FormatMoney(userBalance.Cash);
            BankBox.Text = mf.FormatMoney(userBalance.Card);
            double total = userBalance.Cash + userBalance.Card;
            TotalBox.Text = mf.FormatMoney(total);
            */
        }

    }
}

