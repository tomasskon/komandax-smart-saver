using SmartSaver.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartSaver.Logic.HelperClasses.Savings;
using SmartSaver.Presentation.Helpers;
using SmartSaver.Domain.Repositories;

namespace SmartSaver.Forms.Savings
{
    public partial class GoalEditForm : Form
    {
        SavingGoal _goal;
        SavingsHelper _savingsHelper;

        public GoalEditForm(SavingGoal goal, SavingsHelper savingsHelper)
        {
            InitializeComponent();
            _goal = goal;
            _savingsHelper = savingsHelper;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GoalEditForm_Load(object sender, EventArgs e)
        {
            goalNameLabel.Text = "Name: " + _goal.GoalName;
            goalRemainingLabel.Text = "Amount left: " + (_goal.GoalAmount - _goal.Progress).ToString();
        }

        private async void addToGoalButton_Click(object sender, EventArgs e)
        {
            bool isValid;
            double parsedAmount;
            string parseInfo = SavingsHelper.AmountValidator(addAmountTextBox.Text, out isValid, out parsedAmount);
            if(isValid)
            {
                _goal.Progress += parsedAmount;
                _savingsHelper.AddOrUpdateGoalToDB(_goal); //=> will delete goal if the goal amount is reached
                if(_goal.Progress >= _goal.GoalAmount)
                {
                    MessageBox.Show("The " + _goal.GoalName + " goal has been reached!");
                    await _savingsHelper.DeleteGoalById(_goal.Id);
                }
                Close();
            } else
            {
                MessageBox.Show(parseInfo);
                return;
            }
        }
    }
}
