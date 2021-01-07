using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories.Interfaces;

namespace SmartSaver.Portal.Server.Controllers
{
    [Authorize]
    [Route("transactions")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionsRepository _transactionsRepository;

        public TransactionsController(ITransactionsRepository transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
        }

        [HttpGet("{id}/sorting")]
        public async Task<IReadOnlyList<Transaction>> Get(Guid userId, string sortingColumn, bool isAscending)
        {
            var a = await _transactionsRepository.GetSortedUserTransactions(Domain.Constants.Constants.TestUserId,
                new SortingModel { IsAscending = isAscending, SortingColumn = sortingColumn });

            return a;
        }
    }
}
