using System.Windows.Forms;

namespace SmartSaver.Forms
{
    public class PageControlForm : Form
    {
        protected UserControl mainPage = new UserControls.Main();
        protected UserControl transactionsPage = new UserControls.Transactions();
        protected UserControl savingsPage = new UserControls.Savings();
        protected UserControl spendingsPage = new UserControls.Spendings();
        protected UserControl balancePage = new UserControls.Balance();
        protected UserControl morePage = new UserControls.More();

        protected void ChangePageView(Panel panel, UserControl userControl)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
        }

        protected UserControl GetPageFromButtonName(string buttonName)
        {
            switch (buttonName)
            {
                case "transactionsButton":
                    return transactionsPage;
                case "savingsButton":
                    return savingsPage;
                case "spendingsButton":
                    return spendingsPage;
                case "balanceButton":
                    return balancePage;
                case "moreButton":
                    return morePage;
                default:
                    return mainPage;
            }
        }
    }
}
