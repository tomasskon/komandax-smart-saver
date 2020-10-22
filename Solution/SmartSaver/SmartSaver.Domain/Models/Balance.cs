using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSaver.Domain.Models
{
    public class Balance : IdentityModelBase
    {
        public double Cash { get; set; }

        public double Card { get; set; }

        public Guid UserId { get; set; }

    }
}
