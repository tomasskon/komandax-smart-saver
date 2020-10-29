using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories;

namespace SmartSaver.Logic.HelperClasses.Transactions
{
    public class TransactionsHelper
    {
        private TransactionsRepository _transactionsRepository;

        public TransactionsHelper(TransactionsRepository transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
        }

        public async Task<IReadOnlyList<Transaction>> GetUserTransactions(Guid userId, SortingModel sortingModel)
        {
            return await _transactionsRepository.GetSortedUserTransactions(userId, sortingModel);
        }
    }
}