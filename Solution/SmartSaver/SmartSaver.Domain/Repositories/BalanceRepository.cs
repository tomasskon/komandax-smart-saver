using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSaver.Domain.Models;


namespace SmartSaver.Domain.Repositories
{
    public class BalanceRepository : GenericRepository<Balance>
    {
            public async Task<IReadOnlyList<Balance>> GetUserBalance(Guid userId)
            {
                return await Set.Where(i => i.UserId == userId).ToListAsync();
            }

        public async Task<Balance> GetBalanceIfExist(Guid userID)
        {
            return await Set.SingleOrDefaultAsync(i => i.UserId == userID);
        }
    }
}
