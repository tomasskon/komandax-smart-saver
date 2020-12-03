using System;
using System.Collections.Generic;

namespace SmartSaver.Presentation.Models
{
    public class SavingGoal
    {
        /*
        public string GoalName { get; set; }

        public string Description { get; set; }

        public double GoalAmount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public double Progress { get; set; }

        public double ProgressPercentageValue
        {
            get => (Progress / GoalAmount) * 100;
        }

        public Guid UserId { get; set; }
        */

        public string GoalName { get; set; }

        public string Description { get; set; }

        public double GoalAmount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public double Progress { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public double ProgressPercentageValue
        {
            get => (Progress / GoalAmount) * 100;
        }
    }
}