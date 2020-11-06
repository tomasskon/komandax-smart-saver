using SmartSaver.Domain.Models;
using SmartSaver.Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartSaver.Presentation.Helpers;
using SmartSaver.Logic.HelperClasses.Savings;


namespace SmartSaver.Forms.Savings
{
    public partial class SavingsGoalForm : Form
    {
        SavingsHelper _savingsHelper;
        public SavingsGoalForm(SavingsHelper savingsHelper)
        {
            InitializeComponent();
            _savingsHelper = savingsHelper;
        }

        private void addGoalButton_Click(object sender, EventArgs e)
        {
            bool successfulAmountParse = false;
            double goalAmount;
            string parseMessage = SavingsHelper.AmountValidator(goalAmountTextBox.Text, out successfulAmountParse, out goalAmount);

            if(successfulAmountParse == false)
            {
                Error.ShowDialog(parseMessage);
                return;
            }

            bool successfulDateValidation = false;
            string dateValidationMessage = SavingsHelper.GoalDateValidator(endDateCalendar.SelectionStart, out successfulDateValidation);

            if(successfulDateValidation == false)
            {
                Error.ShowDialog(dateValidationMessage);
                return;
            }

            if(string.IsNullOrEmpty(goalNameTextBox.Text))
            {
                MessageBox.Show("Please provide a name for your goal.");
                return;
            } else if(string.IsNullOrEmpty(goalAmountTextBox.Text))
            {
                MessageBox.Show("Please provide an amount you want to reach for your goal.");
            }


            SavingGoal goal = new SavingGoal()
            {
                GoalName = goalNameTextBox.Text,
                Description = goalDescriptionTextBox.Text,
                GoalAmount = goalAmount,
                StartDate = DateTime.Now,
                FinishDate = endDateCalendar.SelectionStart,
                UserId = Domain.Constants.Constants.TestUserId,
            };

            SendGoalToDB(goal);
            ResetTextBoxValues();
            Hide();
            
        }

        private void ResetTextBoxValues()
        {
            goalNameTextBox.Text = "";
            goalDescriptionTextBox.Text = "";
            goalAmountTextBox.Text = "";
            endDateCalendar.SetDate(DateTime.Now);
        }

        private void SendGoalToDB(SavingGoal goal)
        {
            _savingsHelper.AddOrUpdateGoalToDB(goal);
        }
    }
}
