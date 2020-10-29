using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartSaver.Domain.Repositories;

namespace SmartSaver.Logic.HelperClasses.Balance
{
    public class BalanceHelper
    {
        private UserRepository _userRepository;
        public BalanceHelper(UserRepository UserRepository)
        {
            _userRepository = UserRepository;
        }
        public async Task<Domain.Models.User> GetUserBalance(Guid userId)
        {
            return await _userRepository.GetById(userId);
        }
        public async void AddCashToDb(string text, Domain.Models.User user)
        {
            user.Cash = double.Parse(text);
            await _userRepository.Update(user.Id, user);
        }
        public async void AddCardToDb(string text, Domain.Models.User user)
        {
            user.Card = double.Parse(text);
            await _userRepository.Update(user.Id, user);
        }


    }
}
