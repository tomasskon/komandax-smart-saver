using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartSaver.Forms.SpendingsCategorization
{
    public partial class SpendingCategorization : Form
    {
        private TransactionsListDummyForm _transactionsListForm;
        public SpendingCategorization()
        {
            InitializeComponent();
        }

        private void SpendingCategorization_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void paymentHistoryButton_Click(object sender, EventArgs e)
        {
            //Point to transactions list FORM
            _transactionsListForm = new TransactionsListDummyForm();
            //Optional: Closing previous form:
            this.Close();
            _transactionsListForm.ShowDialog();
        }

        private void transportation_label_Click(object sender, EventArgs e)
        {

        }
    }
}
