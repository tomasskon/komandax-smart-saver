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

            SavingGoal goal = new SavingGoal()
            {
                GoalName = goalNameTextBox.Text,
                Description = goalDescriptionTextBox.Text,
                GoalAmount = goalAmount,
                StartDate = DateTime.Now,
                FinishDate = endDateCalendar.SelectionStart,
            };

            SendGoalToDB(goal);
            

        }

        private void SendGoalToDB(SavingGoal goal)
        {
            _savingsHelper.AddOrUpdateGoalToDB(goal);
        }
    }
}
