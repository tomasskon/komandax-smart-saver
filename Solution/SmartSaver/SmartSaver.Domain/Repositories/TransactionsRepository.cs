using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSaver.Domain.Models;

namespace SmartSaver.Domain.Repositories
{
    public class TransactionsRepository : GenericRepository<Transaction>
    {
        public async Task<IReadOnlyList<Transaction>> GetUserTransactions(Guid userId)
        {
            return await Set.Where(i => i.UserId == userId).ToListAsync();
        }
    }
}