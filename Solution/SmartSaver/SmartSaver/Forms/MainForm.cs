using System.Windows.Forms;
using SmartSaver.Forms;

namespace SmartSaver
{
    public partial class MainForm : PageControlForm
    {
        public MainForm()
        {
            InitializeComponent();

            ChangePageView(pagePanel, mainPage);
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
