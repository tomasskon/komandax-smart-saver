using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartSaver.Domain.Models
{
    public class Transaction : IdentityModelBase
    {
        public int Amount { get; set; }

        public string Description { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreatedAt { get; set; }

        [NotMapped]
        public double RealAmount
        {
            get => (double)Amount / 100;
            set => Amount = (int)value * 100;
        }
    }
}