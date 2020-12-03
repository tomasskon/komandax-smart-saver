using System;
using System.Collections.Generic;
using System.Text;
using SmartSaver.Presentation.Models;

namespace SmartSaver.Presentation.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Gmail { get; set; }

        public double Cash { get; set; }

        public double Card { get; set; }

        public string FullName { get; set; }

        public byte[] UserImage { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
