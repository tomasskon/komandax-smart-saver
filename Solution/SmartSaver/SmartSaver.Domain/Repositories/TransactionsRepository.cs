using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSaver.Domain.Models;
using System.Linq.Expressions;

namespace SmartSaver.Domain.Repositories
{
    public class TransactionsRepository : GenericRepository<Transaction>
    {
        public async Task<IReadOnlyList<Transaction>> GetSortedUserTransactions(Guid userId, SortingModel sortingModel)
        {
            var query = Set.Where(i => i.UserId == userId);

            query = sortingModel.OrderByColumn(query);

            return await query.ToListAsync();
        }
    }
}