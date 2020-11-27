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

        public TransactionController(ITransactionsRepository transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
        }

        [HttpGet("{id}/sorting")]
        public async Task<IReadOnlyList<Transaction>> Get(Guid userId, string sortingColumn, bool isAscending)
        {
            return await _transactionsRepository.GetSortedUserTransactions(Domain.Constants.Constants.TestUserId,
                new SortingModel { IsAscending = isAscending, SortingColumn = sortingColumn });
        }
    }
}
