using System;
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
    
        [HttpGet("")]
        public async Task<IReadOnlyList<SavingGoal>> Get(Guid userId, string sortingColumn, bool isAscending)
        {
            return await _savingGoalsRepository.GetSortedGoals(Domain.Constants.Constants.TestUserId,
                new SortingModel { IsAscending = isAscending, SortingColumn = sortingColumn });
        }

        [HttpPost]
        public async Task<Guid> Store(SavingGoal goal)
        {
            goal.UserId = Domain.Constants.Constants.TestUserId;
            return await _savingGoalsRepository.Create(goal);
        }

        [Route("")]
        [HttpDelete]
        public async Task<NoContentResult> Delete(Guid id)
        {
            await _savingGoalsRepository.Delete(id);
            return NoContent();
        }

        [Route("")]
        [HttpPut]
        public async void Update(SavingGoal goal)
        {
            await _savingGoalsRepository.Update(goal.Id, goal);
        }


    }
}
