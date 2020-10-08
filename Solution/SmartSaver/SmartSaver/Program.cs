using SmartSaver.Forms.SpendingsCategorization;
using System;
using System.Windows.Forms;

namespace SmartSaver
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SpendingCategorization());
        }
    }
}
