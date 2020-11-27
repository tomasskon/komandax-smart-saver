using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSaver.Presentation.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Gmail { get; set; }
        [Required]
        [Range(0, double.MaxValue,
            ErrorMessage = "Price must be between 0 and 100.00")]
        public double Cash { get; set; }
        [Required]
        [Range(0, double.MaxValue,
            ErrorMessage = "Price must be between 0 and 100.00")]
        public double Card { get; set; }

        public string FullName { get; set; }

        public byte[] UserImage { get; set; }
    }
}
