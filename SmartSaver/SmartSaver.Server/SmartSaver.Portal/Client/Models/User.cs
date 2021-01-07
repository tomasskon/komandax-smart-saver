using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartSaver.Portal.Client.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Gmail { get; set; }
        [Required]
        [Range(0, double.MaxValue,
            ErrorMessage = "Amount must be non-negative")]
        public double Cash { get; set; }
        [Required]
        [Range(0, double.MaxValue,
            ErrorMessage = "Amount must be non-negative")]
        public double Card { get; set; }

        public string FullName { get; set; }

        public byte[] UserImage { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
