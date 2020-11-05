using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartSaver.Forms.Savings
{
    public partial class DesignatedFinancialPlanForm : Form
    {
        public DesignatedFinancialPlanForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DesignatedFinancialPlanForm_Load(object sender, EventArgs e)
        {

        }

        private void DesignatedFinancialPlanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
