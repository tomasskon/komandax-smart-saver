using System.Windows.Forms;
using SmartSaver.Forms.Savings;
using SmartSaver.Domain.Models;
using SmartSaver.Logic.HelperClasses.Savings;
using SmartSaver.Domain.Repositories;
using SmartSaver.Presentation.Helpers;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Collections.Generic;
using System;
using SmartSaver.Domain.SortingDirection;
using SmartSaver.Domain.Enums;

namespace SmartSaver.Forms.UserControls
{

    public partial class Savings : UserControl
    {
        private SavingsHelper _savingsHelper;
        private GoalEditForm _editForm;
        private SortingModel _sortingModel;

        public Savings()
        {
            InitializeComponent();
            _savingsHelper = new SavingsHelper(new SavingsRepository());

            _sortColumn.DataSource = new BindingSource(Enum.GetValues(typeof(SavingGoalsSortingColumns)), null);
            _sortColumn.SelectedIndex = 0;
            _sortDirection.DataSource = new BindingSource(Enum.GetValues(typeof(SortingDirections)), null);
            _sortDirection.SelectedIndex = 1;

            _sortingModel = new SortingModel()
            {
                SortingColumn = "GoalName",
                IsAscending = true,
            };

            ReloadSavingGoals();            
        }

        private ListViewItem[] GetGoalsListViewItems(IReadOnlyList<SavingGoal> savingGoals)
        {
            var listViewItems = new List<ListViewItem>();
            foreach (var goal in savingGoals)
            {
                var item = new ListViewItem(goal.GoalName);
                item.SubItems.Add(goal.Description);
                item.SubItems.Add(goal.GoalAmount.ToString());
                item.SubItems.Add(goal.StartDate.ToString("yyyy-MM-dd"));
                item.SubItems.Add(goal.Progress.ToString());
                item.SubItems.Add(goal.ProgressPercentageValue.ToString("0.00"));
                item.SubItems.Add(goal.FinishDate.ToString("yyyy-MM-dd"));
                item.SubItems.Add(goal.Id.ToString());
                listViewItems.Add(item);
            }
            return listViewItems.ToArray();
        }

        private async void ReloadSavingGoals()
        {
            try
            {
                var savingGoals = await _savingsHelper.GetSortedGoals(Domain.Constants.Constants.TestUserId, _sortingModel);

                var listViewItems = GetGoalsListViewItems(savingGoals);

                savingGoalsList.Items.Clear();
                savingGoalsList.Items.AddRange(listViewItems);
            } catch (ArgumentNullException ex)
            {
                Error.ShowDialog(ex.Message);
            }
        }

        private void ReloadSavingsButton_Click(object sender, EventArgs e) => ReloadSavingGoals();

        private void _sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_sortingModel != null)
            {
                _sortingModel.SortingColumn = _sortColumn.SelectedValue.ToString();
                _sortingModel.IsAscending = _sortDirection.SelectedItem.Equals(SortingDirections.Ascending);

                ReloadSavingGoals();
            }
        }

        private void createGoalButton_Click(object sender, EventArgs e)
        {
            SavingsGoalForm goalForm = new SavingsGoalForm(_savingsHelper);
            goalForm.Show();
        }

        private async void removeGoalButton_Click(object sender, EventArgs e)
        {
            if (savingGoalsList.Items.Count > 0)
            {
                ListViewItem listViewItem = savingGoalsList.SelectedItems[0];
                await _savingsHelper.DeleteGoalById(Guid.Parse(listViewItem.SubItems[7].Text.ToString()));
                savingGoalsList.Items.Remove(listViewItem);
            }
        }

        private void editGoalButton_Click(object sender, EventArgs e)
        {
            string parseInfo;
            var stringsToGoal = new List<string>();
            if (savingGoalsList.Items.Count > 0)
            {
                ListViewItem item = savingGoalsList.SelectedItems[0];
                foreach (ListViewItem.ListViewSubItem listItem in item.SubItems)
                {
                    stringsToGoal.Add(listItem.Text);
                }
            }

            var goal = _savingsHelper.StringListToGoal(stringsToGoal, out parseInfo);
            if (goal != null)
            {
                _editForm = new GoalEditForm(goal, _savingsHelper);
                _editForm.Show();
            }
            else
            {
                Error.ShowDialog(parseInfo);
                return;
            }
        }
    }
}
