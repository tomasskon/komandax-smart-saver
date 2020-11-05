using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SmartSaver.Forms.Savings;
using SmartSaver.Domain.Models;
using SmartSaver.Logic.HelperClasses.Savings;
using SmartSaver.Domain.Repositories;
using SmartSaver.Presentation.Helpers;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace SmartSaver.Forms.UserControls
{

    public partial class Savings : UserControl
    {
        //temporary variables:
        SavingsHelper savingsHelper;
        SavingsGoalForm goalForm;
        DesignatedFinancialPlanForm planForm;
        GoalEditForm editForm;
        //temporary ends

        private Dictionary<string, string> _sortColumnDictionary = new Dictionary<string, string>()
        {
            {"goalName", "Goal Name"},
            {"moneyAmount","Amount" },
            {"startedDate","Started" },
            {"progressAmount","Progress"},
            {"goalEnds","Goal Ends" },
        };

        private SortingModel _sortingModel;
        private MoneyFormatter _moneyFormatter = new MoneyFormatter();

        public Savings()
        {
            InitializeComponent();
            goalForm = new SavingsGoalForm(savingsHelper);
            savingsHelper = new SavingsHelper(new SavingsRepository());
            planForm = new DesignatedFinancialPlanForm();

            _sortColumn.DataSource = new BindingSource(_sortColumnDictionary, null);
            _sortColumn.SelectedIndex = 1;

            _sortDirection.DataSource = new BindingSource(SortingModel.DirectionDictionary, null);
            _sortDirection.SelectedIndex = 1;

            _sortingModel = new SortingModel()
            {
                SortingColumn = GetCurrentSortByField(),
                IsAscending = GetCurrentSortDirection()
            };


            //Temporary (Mock Info)
            SavingGoal savings = new SavingGoal()
            {
                GoalName = "Emergency Fund",
                GoalAmount = 500.0,
                Description = "For emergency purposes",
                StartDate = DateTime.Now,
                FinishDate = DateTime.Now,
                Progress = 200.0,
            };
            editForm = new GoalEditForm(savings, savingsHelper);

            ListViewItem item = new ListViewItem(savings.GoalName);
            item.SubItems.Add(savings.Description);
            item.SubItems.Add(savings.GoalAmount.ToString());
            item.SubItems.Add(savings.StartDate.ToString("yyyy-MM-dd"));
            item.SubItems.Add(savings.Progress.ToString());
            item.SubItems.Add(savings.ProgressPercentageValue.ToString());
            item.SubItems.Add(savings.FinishDate.ToString("yyyy-MM-dd"));

            savingGoalsList.Items.Add(item);



            /*
            ReloadSavingGoals();
                

            
            */
        }

        private ListViewItem[] GetGoalsListViewItems(IReadOnlyList<SavingGoal> savingGoals)
        {
            var listViewItems = new List<ListViewItem>();
            foreach (var goal in savingGoals)
            {
                var item = new ListViewItem(goal.GoalName);
                item.SubItems.Add(goal.Description);
                item.SubItems.Add(goal.GoalAmount.ToString());
                item.SubItems.Add(goal.StartDate.ToString());
                item.SubItems.Add(goal.Progress.ToString());
                item.SubItems.Add(goal.FinishDate.ToString());

                listViewItems.Add(item);
            }
            return listViewItems.ToArray();
        }

        private async void ReloadSavingGoals()
        {
            /*
            
            try
            {
                var savingGoals = await savingsHelper.GetGoals(Domain.Constants.Constants.TestUserId, _sortingModel);

                var listViewItems = GetGoalsListViewItems(savingGoals);

                savingGoalsList.Items.Clear();
                savingGoalsList.Items.AddRange(listViewItems);
            } catch (ArgumentNullException ex)
            {
                Error.ShowDialog(ex.Message);
            }
            */
        }

        private void ReloadSavingsButton_Click(object sender, EventArgs e) => ReloadSavingGoals();

        private string GetCurrentSortByField() => _sortColumn.SelectedValue != null ? _sortColumn.SelectedValue.ToString() : "Amount";

        private bool GetCurrentSortDirection() => (bool)(_sortDirection.SelectedValue != null ? _sortDirection.SelectedValue : true);
        private void _sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_sortingModel != null)
            {
                _sortingModel.SortingColumn = GetCurrentSortByField();
                _sortingModel.IsAscending = GetCurrentSortDirection();

                ReloadSavingGoals();
            }
        }

        private void createGoalButton_Click(object sender, EventArgs e)
        {
            goalForm.Show();
        }

        private void removeGoalButton_Click(object sender, EventArgs e)
        {
            if (savingGoalsList.Items.Count > 0)
            {
                savingGoalsList.Items.Remove(savingGoalsList.SelectedItems[0]);
                //REMOVE FROM DB

            }
        }

        private void editGoalButton_Click(object sender, EventArgs e)
        {
            string parseInfo;
            List<string> stringsToGoal = new List<string>();
            if (savingGoalsList.Items.Count > 0)
            {
                ListViewItem item = savingGoalsList.SelectedItems[0];
                foreach (ListViewItem.ListViewSubItem listItem in item.SubItems)
                {
                    stringsToGoal.Add(listItem.Text);
                }
            }



            var goal = SavingsHelper.StringListToGoal(stringsToGoal, out parseInfo);
            if (goal != null)
            {
                editForm = new GoalEditForm(goal, savingsHelper);
                editForm.Show();
            } else
            {
                Error.ShowDialog(parseInfo);
                return;
            }


        }

        private void generatePlanButton_Click(object sender, EventArgs e)
        {
            planForm.Show();
        }
    }
}
