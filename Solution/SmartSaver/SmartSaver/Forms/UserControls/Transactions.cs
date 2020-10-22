﻿using System;
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

        public SortingModel _sortingModel = new SortingModel();

        public Transactions()
        {
            InitializeComponent();

            reloadTransactions();

            _sortColumn.DataSource = new BindingSource(_sortColumnDictionary, null);
            _sortColumn.SelectedIndex = 2;
            _sortDirection.DataSource = new BindingSource(SortingModel.DirectionDictionary, null);
            _sortDirection.SelectedIndex = 1;
        }

        private void _transactions_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private ListViewItem[] getTransactionsListViewItems(IReadOnlyList<Domain.Models.Transaction> transactions)
        {
            var listViewItems = new List<ListViewItem>();

            foreach (var transaction in transactions)
            {
                var item = new ListViewItem(transaction.RealAmount.ToString());
                item.SubItems.Add(transaction.Description);
                item.SubItems.Add(transaction.CreatedAt.ToString());
                
                listViewItems.Add(item);
            }

            return listViewItems.ToArray();
        }

        private async void reloadTransactions()
        {
            var transactionHelper = new TransactionsHelper(new TransactionsRepository());
            //try
            //{
                var transactions = await transactionHelper
                    .GetUserTransactions(Domain.Constants.Constants.TestUserId, _sortingModel);

                var listViewItems = getTransactionsListViewItems(transactions);

                _transactions.Items.Clear();
                _transactions.Items.AddRange(listViewItems);
            /*} 
            catch (ArgumentNullException ex)
            {
                Error.ShowErrorDialog(ex.Message);
            }*/
        }

        private void _loadData_Click(object sender, System.EventArgs e) => reloadTransactions();

        private string getCurrentSortByField() => _sortColumn.SelectedValue != null ? _sortColumn.SelectedValue.ToString() : "Amount";

        private bool getCurrentSortDirection() => (bool)(_sortDirection.SelectedValue != null ? _sortDirection.SelectedValue : true);

        private void _sort_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _sortingModel.SortingColumn = getCurrentSortByField();
            _sortingModel.IsAscending = getCurrentSortDirection();

            reloadTransactions();
        }
    }
}
