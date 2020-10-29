using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories;
using SmartSaver.Logic.HelperClasses.Transactions;
using SmartSaver.Presentation.Helpers;

namespace SmartSaver.Forms.UserControls
{
    public partial class Transactions : UserControl
    {
        private Dictionary<string, string> _sortColumnDictionary = new Dictionary<string, string>()
        {
            {"Amount", "Amount"},
            {"Description", "Description"},
            {"CreatedAt", "Created At"}
        };

        private SortingModel _sortingModel;
        private MoneyFormatter _moneyFormatter = new MoneyFormatter();

        public Transactions()
        {
            InitializeComponent();

            _sortColumn.DataSource = new BindingSource(_sortColumnDictionary, null);
            _sortColumn.SelectedIndex = 2;

            _sortDirection.DataSource = new BindingSource(SortingModel.DirectionDictionary, null);
            _sortDirection.SelectedIndex = 1;

            _sortingModel = new SortingModel()
            {
                SortingColumn = GetCurrentSortByField(),
                IsAscending = GetCurrentSortDirection()
            };

            ReloadTransactions();
        }

        private ListViewItem[] GetTransactionsListViewItems(IReadOnlyList<Domain.Models.Transaction> transactions)
        {
            var listViewItems = new List<ListViewItem>();

            foreach (var transaction in transactions)
            {
                var item = new ListViewItem(_moneyFormatter.FormatMoney(transaction.RealAmount));
                item.SubItems.Add(transaction.Description);
                item.SubItems.Add(transaction.CreatedAt.ToString());
                
                listViewItems.Add(item);
            }

            return listViewItems.ToArray();
        }

        private async void ReloadTransactions()
        {
            /*
            var transactionHelper = new TransactionsHelper(new TransactionsRepository());
            try
            {
                var transactions = await transactionHelper
                    .GetUserTransactions(Domain.Constants.Constants.TestUserId, _sortingModel);

                var listViewItems = GetTransactionsListViewItems(transactions);

                _transactions.Items.Clear();
                _transactions.Items.AddRange(listViewItems);
            } 
            catch (ArgumentNullException ex)
            {
                Error.ShowDialog(ex.Message);
            }
            */
        }

        private void _loadData_Click(object sender, System.EventArgs e) => ReloadTransactions();

        private string GetCurrentSortByField() => _sortColumn.SelectedValue != null ? _sortColumn.SelectedValue.ToString() : "Amount";

        private bool GetCurrentSortDirection() => (bool)(_sortDirection.SelectedValue != null ? _sortDirection.SelectedValue : true);

        private void _sort_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (_sortingModel != null)
            {
                _sortingModel.SortingColumn = GetCurrentSortByField();
                _sortingModel.IsAscending = GetCurrentSortDirection();

                ReloadTransactions();
            }
        }
    }
}
