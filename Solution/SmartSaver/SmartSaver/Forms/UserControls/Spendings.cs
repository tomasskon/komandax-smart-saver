using System;
using System.Windows.Forms;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories;
using SmartSaver.Logic.HelperClasses.Categories;

namespace SmartSaver.Forms.UserControls
{
    public partial class Spendings : UserControl
    {
        public Spendings()
        {
            InitializeComponent();
            ReloadData();
        }

        private async void createCategory_Click(object sender, System.EventArgs e)
        {
            var helper = new CategoriesHelper(new CategoriesRepository());
            var newCategory = new Category
            {
                Name = newCategoryInput.Text,
                UserId = Domain.Constants.Constants.TestUserId
            };

            await helper.AddNewCategory(newCategory);
            newCategoryInput.Text = String.Empty;
            ReloadData();
        }

        private async void ReloadData()
        {
            categoriesList.Items.Clear();
            var categoriesHelper = new CategoriesHelper(new CategoriesRepository());
            var categories = await categoriesHelper
                .GetUserCategories(Domain.Constants.Constants.TestUserId);

            foreach (var category in categories)
            {
                var item = new ListViewItem(category.Name);
                categoriesList.Items.Add(item);
            }
        }
    }
}
