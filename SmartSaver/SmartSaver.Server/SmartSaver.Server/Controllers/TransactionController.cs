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

        [HttpGet]
        public async Task<IReadOnlyList<Transaction>> Get()
        {
            return await _transactionsRepository.GetAll(); ;
        }
    }
}
