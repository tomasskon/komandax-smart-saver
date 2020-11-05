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
        private UserRepository _userRepository;

        public Spendings()
        {
            InitializeComponent();
            ReloadData();
        }

        private async void createCategory_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(newCategoryInput.Text))
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
                newCategoryInput.Text = string.Empty;
                warningLabel.Text = string.Empty;
                ReloadData();
            }
        }

        private async void ReloadData()
        {
            _userRepository = new UserRepository();
            var userId = Domain.Constants.Constants.TestUserId;
            var user = await _userRepository.GetById(userId);
            textBox1.Text = user.Card.FormatMoney();
            textBox2.Text = user.Cash.FormatMoney();
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

        private void CreateTransactionFieldsValidation(out double amount, out string warningText, User user)
        {
            amount = double.NaN;
            warningText = string.Empty;

            if (string.IsNullOrEmpty(spendMoneyInput.Text))
            {
                warningText = "Spend Money Input Field cannot be empty";
            }
            else if (!double.TryParse(spendMoneyInput.Text, out amount))
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
            else if (user is null)
            {
                warningText = "User not found, try to log in again";
            }
            else if ((spendBalance.SelectedIndex == 0 ? user.Cash : user.Card) < amount)
            {
                warningText = "Insufficient balance amount";
            }
        }

        private async void createTransaction_Click(object sender, System.EventArgs e)
        {
            _userRepository = new UserRepository();
            var userId = Domain.Constants.Constants.TestUserId;
            var user = await _userRepository.GetById(userId);

            CreateTransactionFieldsValidation(out double amount, out string warningText, user);

            if (warningText != string.Empty)
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
            await helper.AddNewSpending(newTransaction, user, _userRepository);
            spendMoneyInput.Text = string.Empty;
            warningLabel.Text = string.Empty;
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
            var mainForm = (MainForm) this.FindForm();

            mainForm.ChangePageView(mainForm.transactionsPage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
