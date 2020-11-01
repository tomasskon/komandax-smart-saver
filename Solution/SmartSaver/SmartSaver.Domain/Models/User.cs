using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSaver.Domain.Models
{
    public class User : IdentityModelBase
    {
        public double Cash { get; set; }

        public double Card { get; set; }

        public string FullName { get; set; }

        public byte[] UserImage { get; set; }

        
    }
}
