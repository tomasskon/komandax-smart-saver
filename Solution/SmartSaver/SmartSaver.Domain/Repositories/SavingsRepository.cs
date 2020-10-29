using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSaver.Domain.Models;

namespace SmartSaver.Domain.Repositories
{
    public class SavingsRepository : GenericRepository<Savings>
    {

        public async Task<IReadOnlyList<Savings>> GetUserGoals(Guid userId)
        {
            return await Set.Where(i => i.UserId == userId).ToListAsync();
        }
        public async Task<IReadOnlyList<Savings>> GetSortedUserGoals(Guid userId, SortingModel sortingModel)
        {
            return await sortingModel.OrderByColumn(Set.Where(i => i.UserId == userId)).ToListAsync();
        }


    }
}
