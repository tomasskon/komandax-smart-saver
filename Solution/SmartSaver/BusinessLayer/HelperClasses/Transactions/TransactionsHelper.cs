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

        public async Task AddNewSpending(Transaction transaction, User user, UserRepository userRepository)
        {
            var balance = user.GetType().GetProperty(transaction.BalanceType);
            var balanceAmount = (double) balance.GetValue(user);

            if (balanceAmount >= transaction.AmountDouble)
            {
                balance.SetValue(user, balanceAmount - transaction.AmountDouble);

                await userRepository.Update(user.Id, user);
                await AddNewTransaction(transaction);
            }
        }

        public async Task AddNewTransaction(Transaction transaction)
        {
            await _transactionsRepository.Create(transaction);
        }

        public async Task<IReadOnlyList<Transaction>> GetLastUserTransactions(Guid userId, int count)
        {
            return await _transactionsRepository.GetLastTransactions(userId, count);
        }
    }
}