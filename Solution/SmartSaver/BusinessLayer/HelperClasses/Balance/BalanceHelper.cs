using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartSaver.Domain.Repositories;

namespace SmartSaver.Logic.HelperClasses.Balance
{
    public class BalanceHelper
    {
        private BalanceRepository _balanceRepository;

        public BalanceHelper(BalanceRepository balanceRepository)
        {
            _balanceRepository = balanceRepository;
        }

        public async Task<IReadOnlyList<Domain.Models.Balance>> GetUserBalance(Guid userId)
        {
            return await _balanceRepository.GetUserBalance(userId);
        }

       

        public async void AddCashToDb(string text)
        {
            var balance = new Domain.Models.Balance
            {
                Cash = double.Parse(text),
                UserId = Domain.Constants.Constants.TestUserId
            };
            var repository = new BalanceRepository();
            var userBalance = await repository.GetBalanceIfExist(Domain.Constants.Constants.TestUserId);
            

            if (userBalance != null)
            {

                balance.Card = userBalance.Card;
                
                await repository.Update(userBalance.Id, balance);
            }
            else
                await repository.Create(balance);
        }
        // funny copy paste
        public async void AddCardToDb(string text)
        {
            var balance = new Domain.Models.Balance
            {
                Card = double.Parse(text),
                UserId = Domain.Constants.Constants.TestUserId
            };
            var repository = new BalanceRepository();
            var userBalance = await repository.GetBalanceIfExist(Domain.Constants.Constants.TestUserId);
            
            if (userBalance != null)
            {
                balance.Cash = userBalance.Cash;
                
                await repository.Update(userBalance.Id, balance);
                
            }
            else
                await repository.Create(balance);
        }
    }
}
