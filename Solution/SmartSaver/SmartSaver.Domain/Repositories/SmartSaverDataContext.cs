using Microsoft.EntityFrameworkCore;
using SmartSaver.Domain.Models;

namespace SmartSaver.Domain.Repositories
{
    public class SmartSaverDataContext : DbContext
    {
        public SmartSaverDataContext(DbContextOptions<SmartSaverDataContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        internal DbSet<Transaction> Transactions { get; set; }

        internal DbSet<User> Users { get; set; }

        internal DbSet<Category> Categories { get; set; }

    }
}
