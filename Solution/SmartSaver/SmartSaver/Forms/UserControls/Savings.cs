using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SmartSaver.Forms.Savings;

namespace SmartSaver.Forms.UserControls
{

    private Dictionary<string, string> _sortColumnDictionary = new Dictionary<string, string>()
    {
        { }
    };

    public partial class Savings : UserControl
    {
        //temporary:
        public static bool isUserFirstTime = true;
        public double enteredGoal;
        //temprary ends



        static SavingsGoalForm _savingsGoalForm;
        public Savings()
        {
            InitializeComponent();
            
        }

        public static void ShowSavingsGoal()
        {
            _savingsGoalForm = new SavingsGoalForm();
            _savingsGoalForm.Show();

        }

    }
}
