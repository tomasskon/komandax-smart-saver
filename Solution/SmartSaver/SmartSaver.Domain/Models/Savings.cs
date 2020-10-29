using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartSaver.Domain.Models
{
    public class Savings : IdentityModelBase
    {
        public string GoalName { get; set; }
        public string Description { get; set; }
        public double GoalAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public double AmountRemaining { get; set; }

        [NotMapped]
        public double ProgressPercentageValue {
            get => (GoalAmount / AmountRemaining) * 100;
            set => GoalAmount = (value / AmountRemaining)*100; 
        }
        public Guid UserId { get; set; }
    }
}
