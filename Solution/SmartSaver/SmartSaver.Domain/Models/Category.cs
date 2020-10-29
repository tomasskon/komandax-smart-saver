using System;

namespace SmartSaver.Domain.Models
{
    public class Category : IdentityModelBase
    {
        public string Name { get; set; }

        public Guid UserId { get; set; }
    }
}