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
        public UserControl mainPage = new UserControls.Main();
        public UserControl transactionsPage = new UserControls.Transactions();
        public UserControl savingsPage = new UserControls.Savings();
        public UserControl spendingsPage = new UserControls.Spendings();
        public UserControl balancePage = new UserControls.Balance();
        public UserControl morePage = new UserControls.More();

        public MainForm()
        {
            InitializeComponent();

            ChangePageView(mainPage);
        }

        public void ChangePageView(UserControl userControl)
        {
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(userControl);
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
                ChangePageView(pageControl);
            }
        }
    }
}
