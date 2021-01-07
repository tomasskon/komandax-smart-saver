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
        private readonly ICategoriesRepository _categoriesRepository;

        public TransactionController(ITransactionsRepository transactionsRepository, IUsersRepository usersRepository, ICategoriesRepository categoriesRepository)
        {
            _transactionsRepository = transactionsRepository;
            _usersRepository = usersRepository;
            _categoriesRepository = categoriesRepository;
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

        [HttpPut("{userId}/{type}/{category}/{description}/{amount}")]
        public async Task<ActionResult> SpendExtension(Guid userId, string type, string category, string description, string amount)
        {
            var getCategory = await _categoriesRepository.GetCategoryByName(category);

            if (getCategory != null)
            {
                var user = await _usersRepository.GetById(Domain.Constants.Constants.TestUserId);
                var balance = user.GetType().GetProperty(type);
                var balanceAmount = (double)balance.GetValue(user);

                if (double.TryParse(amount, out var spendAmount))
                {
                    if (balanceAmount >= spendAmount)
                    {
                        var transaction = new Transaction
                        {
                            AmountDouble = spendAmount,
                            BalanceType = type,
                            CategoryId = getCategory.Id,
                            CreatedAt = DateTime.UtcNow,
                            Description = description,
                            UserId = userId
                        };

                        balance.SetValue(user, balanceAmount - spendAmount);

                        await _transactionsRepository.Create(transaction);
                        await _usersRepository.Update(user.Id, user);

                        return Ok();
                    }
                }
            }

            return NotFound();
        }
    }
}
