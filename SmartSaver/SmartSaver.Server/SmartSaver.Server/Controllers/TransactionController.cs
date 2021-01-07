using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories.Interfaces;

namespace SmartSaver.Server.Controllers
{
    [Route("transactions")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionsRepository _transactionsRepository;
        private readonly IUsersRepository _usersRepository;

        public TransactionController(ITransactionsRepository transactionsRepository, IUsersRepository usersRepository)
        {
            _transactionsRepository = transactionsRepository;
            _usersRepository = usersRepository;
        }

        [HttpGet("{id}/sorting")]
        public async Task<IReadOnlyList<Transaction>> Get(Guid userId, string sortingColumn, bool isAscending)
        {
            return await _transactionsRepository.GetSortedUserTransactions(Domain.Constants.Constants.TestUserId,
                new SortingModel { IsAscending = isAscending, SortingColumn = sortingColumn });
        }

        [HttpGet("last/{count}")]
        public async Task<IReadOnlyList<Transaction>> GetLast(int count)
        {
            return await _transactionsRepository.GetLastTransactions(Domain.Constants.Constants.TestUserId, count);
        }

        [HttpGet("grouped")]
        public async Task<IReadOnlyList<GroupedTransaction>> GetGroupedByCategory()
        {
            return await _transactionsRepository.GetAmountSpentPerCategory(Domain.Constants.Constants.TestUserId);
        }


        [HttpPost]
        [Route("spend")]
        public async Task<IActionResult> AddNewSpending(Transaction transaction)
        {
            var user = await _usersRepository.GetById(Domain.Constants.Constants.TestUserId);
            var balance = user.GetType().GetProperty(transaction.BalanceType);
            var balanceAmount = (double)balance.GetValue(user);

            transaction.UserId = user.Id;

            if (balanceAmount >= transaction.AmountDouble)
            {
                balance.SetValue(user, balanceAmount - transaction.AmountDouble);

                await _usersRepository.Update(user.Id, user);
                await _transactionsRepository.Create(transaction);

                return Ok();
            }

            return NotFound();
        }

    }
}
