using System;
using System.ComponentModel.DataAnnotations;

namespace SmartSaver.Presentation.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid UserId { get; set; }
    }
}