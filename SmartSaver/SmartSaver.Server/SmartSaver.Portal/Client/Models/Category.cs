using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartSaver.Portal.Client.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid UserId { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}