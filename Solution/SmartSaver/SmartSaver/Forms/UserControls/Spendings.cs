using System;
using System.Windows.Forms;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories;
using SmartSaver.Logic.HelperClasses.Categories;
using SmartSaver.Logic.HelperClasses.Transactions;
using SmartSaver.Presentation.Forms;

namespace SmartSaver.Forms.UserControls
{
    public partial class Spendings : UserControl
    {
        private ListViewItem _lastSelectedCategory;

        public Spendings()
        {
            InitializeComponent();
            ReloadData();
        }

        private async void createCategory_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(newCategoryInput.Text))
            {
                warningLabel.Text = "Input Field cannot be empty";
            }
            else
            {
                var helper = new CategoriesHelper(new CategoriesRepository());
                var newCategory = new Category
                {
                    Name = newCategoryInput.Text,
                    UserId = Domain.Constants.Constants.TestUserId
                };

                await helper.AddNewCategory(newCategory);
                newCategoryInput.Text = String.Empty;
                warningLabel.Text = String.Empty;
                ReloadData();
            }
        }

        private async void ReloadData()
        {
            categoriesList.Items.Clear();
            var categoriesHelper = new CategoriesHelper(new CategoriesRepository());
            var categories = await categoriesHelper
                .GetUserCategories(Domain.Constants.Constants.TestUserId);

            foreach (var category in categories)
            {
                var item = new ListViewItem(category.Id.ToString());
                item.SubItems.Add(category.Name);
                categoriesList.Items.Add(item);
            }
        }

        private void CreateTransactionFieldsValidation(out double amount, out string warningText)
        {
            amount = Double.NaN;
            warningText = String.Empty;

            if (String.IsNullOrEmpty(spendMoneyInput.Text)) {
                warningText = "Spend Money Input Field cannot be empty";
            } 
            else if (!Double.TryParse(spendMoneyInput.Text, out amount))
            {
                warningText = "Spend Money Input Field must be decimal";
            } 
            else if (_lastSelectedCategory is null)
            {
                warningText = "You must select a category before spending";
            } 
            else if (spendBalance.SelectedIndex < 0)
            {
                warningText = "You must select a balance to spend from";
            }
        }

        private async void createTransaction_Click(object sender, System.EventArgs e)
        {
            double amount;
            string warningText;

            CreateTransactionFieldsValidation(out amount, out warningText);

            if (warningText != "")
            {
                warningLabel.Text = warningText;
                return;
            }

            var categoryId = _lastSelectedCategory.Text;
            var helper = new TransactionsHelper(new TransactionsRepository());
            var newTransaction = new Transaction
            {
                AmountDouble = amount,
                Description = "Spending from Spendings page",
                UserId = Domain.Constants.Constants.TestUserId,
                BalanceType = spendBalance.SelectedItem.ToString(),
                CategoryId = Guid.Parse(categoryId)
            };
            await helper.AddNewTransaction(newTransaction);
            spendMoneyInput.Text = String.Empty;
            warningLabel.Text = String.Empty;
            ReloadData();
        }

        private void categoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriesList.SelectedIndices.Count > 0)
            {
                _lastSelectedCategory = categoriesList.SelectedItems[0];
            }
        }

        private void paymentHistoryButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm) this.FindForm();

            mainForm.ChangePageView(mainForm.transactionsPage);
        }
    }
}
