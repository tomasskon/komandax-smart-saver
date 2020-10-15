using System;

namespace SmartSaver.Domain.Models
{
    public class Transaction : IdentityModelBase
    {
        public int Amount { get; set; }

        public string Description { get; set; }

        public Guid UserId { get; set; }
    }
}