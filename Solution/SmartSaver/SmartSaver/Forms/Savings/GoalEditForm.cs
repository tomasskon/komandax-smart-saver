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
            goalNameLabel.Text = _goal.GoalName;
            goalDescriptionLabel.Text = _goal.Description;
            goalRemainingLabel.Text = "Amount left: " + _goal.Progress.ToString();
        }

        private void addToGoalButton_Click(object sender, EventArgs e)
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
                    MessageBox.Show($"The {1} goal has been reached!", _goal.GoalName);
                }
                Close();
            } else
            {
                Error.ShowDialog(parseInfo);
                return;
            }
        }
    }
}
