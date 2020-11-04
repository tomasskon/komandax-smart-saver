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
        private User _user;
        public Balance()
        {
            InitializeComponent();
            UpdateIfExist();
        }
        private async void Enter_Click(object sender, System.EventArgs e)
        {
            InputBox.ForeColor = Color.Black;
            DataValidation dv = new DataValidation();
            var helper = new BalanceHelper(new UserRepository());
            _user = await helper.GetUserBalance(userId: Domain.Constants.Constants.TestUserId);
            if (dv.ValidateMoneyInput(InputBox.Text))
            {
                switch (InputComboBox.SelectedIndex)
                {
                    case 0:
                        helper.AddCashToDb(InputBox.Text, _user);
                        break;
                    case 1:
                        helper.AddCardToDb(InputBox.Text, _user);
                        break;
                }
                UpdateIfExist();
            }
            else
                InputBox.ForeColor = Color.Red;
        }
        private async void UpdateIfExist()
        {
            var repository = new UserRepository();
            var helper = new BalanceHelper(repository);
            var userBalance = await helper.GetUserBalance(Domain.Constants.Constants.TestUserId);
            CashBox.Text = userBalance.Cash.FormatMoney();
            BankBox.Text = userBalance.Card.FormatMoney();
            double total = userBalance.Cash + userBalance.Card;
            TotalBox.Text = total.FormatMoney();
        }

    }
}

