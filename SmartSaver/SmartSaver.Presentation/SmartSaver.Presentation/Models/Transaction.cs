using System;

namespace SmartSaver.Presentation.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }

        public int Amount { get; set; }

        public string Description { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid CategoryId { get; set; }

        public string BalanceType { get; set; }

        public double AmountDouble
        {
            get => (double)Amount / 100;
            set => Amount = (int)(value * 100);
        }
    }
}