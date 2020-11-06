using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartSaver.Domain.Models
{
    public class SavingGoal : IdentityModelBase
    {
        public string GoalName { get; set; }

        public string Description { get; set; }

        public double GoalAmount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public double Progress { get; set; }

        public Guid UserId { get; set; }


        [NotMapped]
        public double ProgressPercentageValue {
            get => (Progress / GoalAmount) * 100;
        }
    }
}
