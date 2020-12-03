using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories.Interfaces;

namespace SmartSaver.Server.Controllers
{
    [Route("savings")]
    [ApiController]
    public class SavingGoalController : ControllerBase
    {
        private readonly ISavingGoalsRepository _savingGoalsRepository;

        public SavingGoalController(ISavingGoalsRepository savingGoalsRepository)
        {
            _savingGoalsRepository = savingGoalsRepository;
        }

        [HttpGet]
        public async Task<IReadOnlyList<SavingGoal>> Get()
        {
            return await _savingGoalsRepository.GetAll();
        }

        [HttpPut]
        public async void Put(SavingGoal goal)
        {
            await _savingGoalsRepository.Update(Domain.Constants.Constants.TestUserId, goal);
        }
        

    }
}
