using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<IReadOnlyList<Domain.Models.Transaction>> GetUserTransactions(Guid userId)
        {
            return await _transactionsRepository.GetUserTransactions(userId);
        }
    }
}