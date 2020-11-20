using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSaver.Presentation.Models
{
    public class User
    {
        public string Gmail { get; set; }

        public double Cash { get; set; }

        public double Card { get; set; }

        public string FullName { get; set; }

        public byte[] UserImage { get; set; }
    }
}
