using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SmartSaver.Forms.Savings;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories;
using SmartSaver.Logic.HelperClasses.Savings;
using SmartSaver.Presentation.Helpers;

namespace SmartSaver.Forms.UserControls
{
    public partial class Savings : UserControl
    {
        //temporary variables:
        SavingsGoalForm goalForm = new SavingsGoalForm();

        //temporary ends

        private Dictionary<string, string> _sortColumnDictionary = new Dictionary<string, string>()
        {
            {"goalName", "Goal Name"},
            {"moneyAmount","Amount" },
            {"startedDate","Started" },
            {"progressAmount","Progress" },
            {"goalEnds","Goal Ends" },
        };

        private SortingModel _sortingModel;
        //private MoneyFormatter _moneyFormatter = new MoneyFormatter();

        public Savings()
        {
            InitializeComponent();

            _sortColumn.DataSource = new BindingSource(_sortColumnDictionary, null);
            _sortColumn.SelectedIndex = 1;

            _sortDirection.DataSource = new BindingSource(SortingModel.DirectionDictionary, null);
            _sortDirection.SelectedIndex = 1;


            Domain.Models.Savings savings = new Domain.Models.Savings()
            {
                GoalName = "Emergency Fund",
                GoalAmount = 500.0,
                Description = "For emergency purposes",
                StartDate = DateTime.Now,
                FinishDate = DateTime.Now,
                AmountRemaining = 200.0,
            };

            ListViewItem item = new ListViewItem(savings.GoalName);
            item.SubItems.Add(savings.Description);
            item.SubItems.Add(savings.GoalAmount.ToString());
            item.SubItems.Add(savings.StartDate.ToString("yyyy-MM-dd"));
            item.SubItems.Add(savings.AmountRemaining.ToString());
            item.SubItems.Add(savings.ProgressPercentageValue.ToString());
            item.SubItems.Add(savings.FinishDate.ToString("yyyy-MM-dd"));


            savingGoalsList.Items.Add(item);

            /*
            _sortingModel = new SortingModel()
            {
                SortingColumn = GetCurrentSortByField(),
                IsAscending = GetCurrentSortDirection()
            };

            ReloadSavingGoals();
            */
        }

        private ListViewItem[] GetGoalsListViewItems(IReadOnlyList<Domain.Models.Savings> savings)
        {
            var listViewItems = new List<ListViewItem>();
            foreach(var goal in savings)
            {
                var item = new ListViewItem();
                listViewItems.Add(item);
            }
            return listViewItems.ToArray();
        }

        private async void ReloadSavingGoals()
        {

            
            /*
            var savingsHelper = new SavingsHelper(new SavingsRepository());

            
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
            if(_sortingModel != null)
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
    }
}
