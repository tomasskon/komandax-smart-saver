﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SmartSaver.Forms.Savings;

namespace SmartSaver.Forms.UserControls
{
    public partial class Savings : UserControl
    {
        
        SavingsGoalForm savingsGoalForm;
        public Savings()
        {
            InitializeComponent();
            savingsGoalForm = new SavingsGoalForm();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
