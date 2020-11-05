using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories;

namespace SmartSaver.Logic.HelperClasses.Savings
{
    public class SavingsHelper
    {
        private readonly SavingsRepository _savingsRepository;

        public SavingsHelper(SavingsRepository savingsRepository)
        {
            _savingsRepository = savingsRepository;
        }

        
        public async Task<IReadOnlyList<SavingGoal>> GetGoals(Guid userId)
        {
            return await _savingsRepository.GetUserGoals(userId);
        }

        public async Task<IReadOnlyList<SavingGoal>> GetSortedGoals(Guid userId, SortingModel sortingModel)
        {
            return await _savingsRepository.GetSortedGoals(userId, sortingModel);
        }

        public async Task DeleteGoalById(Guid id)
        {
             await _savingsRepository.Delete(id);
        }

        public static string AmountValidator(string amountText, out bool success, out double amountParsed)
        {
            double amount;
            amountParsed = 0;
            try
            {
                amount = double.Parse(amountText);
            }
            catch (FormatException ex)
            {
                success = false;
                return "Invalid goal amount input.";
            }

            if (amount <= 0)
            {
                success = false;
                return "Invalid goal amount input. Goal amount must be at least above zero";
            }
            success = true;
            amountParsed = amount;
            return "Success";
        }

        public static string GoalDateValidator(DateTime finishDate, out bool isValid)
        {
            if(DateTime.Now.Day-1 < finishDate.Day)
            {
                isValid = true;
                return "Goal Date Validation Success";
            } else
            {
                isValid = false;
                return "Invalid date input. Set goal date is set in the past...";
            }
        }


        public async void AddOrUpdateGoalToDB(SavingGoal goal)
        {
            var repository = new SavingsRepository();
            var tempGoal = await repository.GetUserGoalIfExists(goal);

            if(goal.Progress >= goal.GoalAmount)
            {
                //goal COMPLETED
                return;
            }


            if(tempGoal != null)
            {
                await repository.Update(goal.Id, goal);
            } else
            {
                await repository.Create(goal);
            }
        }

        public SavingGoal StringListToGoal(List<string> info, out string parseInfo)
        {
            parseInfo = "";
            try
            {
                double goalAmount = double.Parse(info[2]);
                DateTime startDate = DateTime.Parse(info[3]);
                double amountRemaining = double.Parse(info[4]);
                DateTime finishDate = DateTime.Parse(info[6]);
                Guid id = Guid.Parse(info[7]);
                parseInfo = "Success";
                return new SavingGoal()
                {
                    GoalName = info[0],
                    Description = info[1],
                    GoalAmount = goalAmount,
                    StartDate = startDate,
                    Progress = amountRemaining,
                    FinishDate = finishDate,
                    UserId = Domain.Constants.Constants.TestUserId,
                    Id = id,
                };

            } catch(Exception ex)
            {
                parseInfo = ex.Message;
                return null;
            }

        }



    }
}
