using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartSaver.Domain.Enums;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories;
using SmartSaver.Domain.SortingDirection;
using SmartSaver.Logic.HelperClasses.Transactions;
using SmartSaver.Presentation.Helpers;

namespace SmartSaver.Forms.UserControls
{
    public partial class Transactions : UserControl
    {
        private SortingModel _sortingModel;

        public Transactions()
        {
            InitializeComponent();

            _sortColumn.DataSource = new BindingSource(Enum.GetValues(typeof(TransactionsSortingColumns)), null);
            _sortColumn.SelectedIndex = 2;

            _sortDirection.DataSource = new BindingSource(Enum.GetValues(typeof(SortingDirections)), null);
            _sortDirection.SelectedIndex = 1;

            _sortingModel = new SortingModel()
            {
                SortingColumn = "CreatedAt",
                IsAscending = false
            };

            ReloadTransactions();
        }

        private ListViewItem[] GetTransactionsListViewItems(IReadOnlyList<Domain.Models.Transaction> transactions)
        {
            var listViewItems = new List<ListViewItem>();

            foreach (var transaction in transactions)
            {
                var item = new ListViewItem(transaction.Id.ToString());
                item.SubItems.Add(transaction.Category.Name);
                item.SubItems.Add(transaction.AmountDouble.FormatMoney());
                item.SubItems.Add(transaction.BalanceType);

                item.SubItems.Add(transaction.Description);
                item.SubItems.Add(transaction.CreatedAt.ToString("yyyy-MM-dd HH:mm"));
                
                listViewItems.Add(item);
            }

            return listViewItems.ToArray();
        }

        private async void ReloadTransactions()
        {
            
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
            
        }

        private void _loadData_Click(object sender, System.EventArgs e) => ReloadTransactions();

        private void _sort_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (_sortingModel != null)
            {
                _sortingModel.SortingColumn = _sortColumn.SelectedValue.ToString();
                _sortingModel.IsAscending = _sortDirection.SelectedItem.Equals(SortingDirections.Ascending);

                ReloadTransactions();
            }
        }
    }
}
