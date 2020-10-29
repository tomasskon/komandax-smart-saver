using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories;

namespace SmartSaver.Logic.HelperClasses.Savings
{
    class SavingsHelper
    {
        private SavingsRepository _savingsRepository;

        public SavingsHelper(SavingsRepository savingsRepository)
        {
            _savingsRepository = savingsRepository;
        }

      



    }
}
