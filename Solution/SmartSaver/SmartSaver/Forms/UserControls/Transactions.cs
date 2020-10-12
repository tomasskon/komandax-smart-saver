using System.Windows.Forms;
using SmartSaver.Domain.Repositories;
using SmartSaver.Logic.HelperClasses.Transactions;

namespace SmartSaver.Forms.UserControls
{
    public partial class Transactions : UserControl
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void _transactions_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private async void _loadData_Click(object sender, System.EventArgs e)
        {
            var transactionHelper = new TransactionsHelper(new TransactionsRepository());
            var transactions = await transactionHelper
                .GetUserTransactions(Domain.Constants.Constants.TestUserId);

            foreach (var transaction in transactions)
            {
                var item = new ListViewItem(transaction.Amount.ToString());
                item.SubItems.Add(transaction.Description);
                _transactions.Items.Add(item);
            }
            
        }
    }
}
