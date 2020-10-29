using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSaver.Domain.Models;

namespace SmartSaver.Domain.Repositories
{
    public class UserLoginsRepository
    {
        private protected readonly SmartSaverDataContext Context = new SmartSaverDataContext(new DbContextOptionsBuilder<SmartSaverDataContext>()
            .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SmartSaver;Integrated Security=True").Options);
        private protected DbSet<UserLogin> Set => Context.Set<UserLogin>();

        public async Task<byte[]> GetUserLogin(Guid userId)
        {
            return (await Set.SingleOrDefaultAsync(s => s.UserId == userId))?.LoginData;
        }

        public async Task CreateUserLogin(Guid userId, byte[] loginData)
        {
            var userLogin = new UserLogin
            {
                UserId = userId,
                LoginData = loginData
            };

            Set.Add(userLogin);
            await Context.SaveChangesAsync();
        }
    }
}