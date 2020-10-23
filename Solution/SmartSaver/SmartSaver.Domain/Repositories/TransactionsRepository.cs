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
                .ToListAsync();
        }
    }
}