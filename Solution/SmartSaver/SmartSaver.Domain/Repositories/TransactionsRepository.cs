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
        public async Task<IReadOnlyList<Transaction>> GetSortedUserTransactions(Guid userId, SortingModel sortingModel)
        {
            return await sortingModel
                .OrderByColumn(Set.Where(i => i.UserId == userId))
                .Include(u => u.Category)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<Transaction>> GetLastTransactions(Guid userId, int count = 5)
        {
            return await Set
                .Where(i => i.UserId == userId)
                .Include(i => i.Category)
                .OrderByDescending(i => i.CreatedAt)
                .Take(count)
                .ToListAsync();
        }
    }
}