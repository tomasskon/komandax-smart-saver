using System.Collections.Generic;
using System.Windows.Forms;
using SmartSaver.Domain.Repositories;
using UserControls = SmartSaver.Forms.UserControls;
using SmartSaver.Domain.Repositories.Interfaces;
using SmartSaver.Forms.UserControls;

namespace SmartSaver.Presentation.Forms
{
    public partial class MainForm : Form
    {
        protected UserControl mainPage = new UserControls.Main();
        protected UserControl transactionsPage = new UserControls.Transactions();
        protected UserControl savingsPage = new UserControls.Savings();
        protected UserControl spendingsPage = new UserControls.Spendings();
        protected UserControl balancePage = new UserControls.Balance();
        protected UserControl morePage = new UserControls.More();

        public MainForm()
        {
            InitializeComponent();

            ChangePageView(pagePanel, mainPage);
        }

        protected void ChangePageView(Panel panel, UserControl userControl)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
        }

        protected UserControl GetPageFromButtonName(string buttonName)
        {
            Dictionary<string, UserControl> dictionary = new Dictionary<string, UserControl>()
            {
                { "homeButton", mainPage },
                { "transactionsButton", transactionsPage },
                { "savingsButton", savingsPage },
                { "spendingsButton", spendingsPage },
                { "balanceButton", balancePage },
                { "moreButton", morePage }
            };

            return dictionary.GetValueOrDefault(buttonName, mainPage);
        }

        private void NavigationButtonClick(object sender, System.EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button) sender;
                UserControl pageControl = GetPageFromButtonName(button.Name);
                ChangePageView(pagePanel, pageControl);
            }
        }
    }
}
