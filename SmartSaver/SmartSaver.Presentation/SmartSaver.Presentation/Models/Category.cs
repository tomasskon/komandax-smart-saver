using System;
using System.Collections.Generic;

namespace SmartSaver.Presentation.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid UserId { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}