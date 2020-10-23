using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SmartSaver.Presentation.Helpers
{
    class Error
    {
        public static bool ShowDialog(string message)
        {
            string title = "Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;

            DialogResult result = MessageBox.Show(message, title, buttons, icon);

            return result == DialogResult.OK;
        }
    }
}
