using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSaver.Domain.Models;

namespace SmartSaver.Domain.Repositories
{
    public class SavingsRepository : GenericRepository<SavingGoal>
    {
        
        public async Task<SavingGoal> GetUserGoalIfExists(SavingGoal goal)
        {
            return await Set.SingleOrDefaultAsync(i => i.GoalName == goal.GoalName);
        }
        public async Task<IReadOnlyList<SavingGoal>> GetSortedUserGoals(Guid userId, SortingModel sortingModel)
        {
            return await sortingModel
                .OrderByColumn(Set.Where(i => i.UserId == userId))
                .ToListAsync();
        }
        


    }
}
