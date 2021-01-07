using System;

namespace SmartSaver.Portal.Client.Models
{
    public class Transaction
    {
        public int Amount { get; set; }

        public string Description { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual User User { get; set; }

        public string BalanceType { get; set; }

        public double AmountDouble
        {
            get => (double)Amount / 100;
            set => Amount = (int)(value * 100);
        }
    }
}