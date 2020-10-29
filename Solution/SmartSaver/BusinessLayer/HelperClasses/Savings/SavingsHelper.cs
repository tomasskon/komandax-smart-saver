using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories;

namespace SmartSaver.Logic.HelperClasses.Savings
{
    public class SavingsHelper
    {
        private SavingsRepository _savingsRepository;

        public SavingsHelper(SavingsRepository savingsRepository)
        {
            _savingsRepository = savingsRepository;
        }

        
        public async Task<IReadOnlyList<Domain.Models.Savings>> GetGoals(Guid userId, SortingModel sortingModel)
        {
            return await _savingsRepository.GetSortedUserGoals(userId, sortingModel);
        }
        



    }
}
