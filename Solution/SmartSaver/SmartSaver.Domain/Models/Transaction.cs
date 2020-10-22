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
        public decimal RealAmount
        {
            get => (decimal)Amount / 100;
            set => Amount = (int)value * 100;
        }
    }
}