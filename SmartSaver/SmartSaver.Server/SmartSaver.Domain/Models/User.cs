using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSaver.Domain.Models
{
    public partial class User : IdentityModelBase
    {
        public User()
        {
            Goals = new HashSet<SavingGoal>();
            Transactions = new HashSet<Transaction>();
        }

        public string Gmail { get; set; }

        public double Cash { get; set; }

        public double Card { get; set; }

        public string FullName { get; set; }

        public byte[] UserImage { get; set; }

        public virtual ICollection<SavingGoal> Goals { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
