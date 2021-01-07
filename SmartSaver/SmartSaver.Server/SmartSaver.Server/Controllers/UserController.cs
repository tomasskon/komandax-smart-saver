using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories.Interfaces;

namespace SmartSaver.Server.Controllers
{
    [Route("users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsersRepository _usersRepository;

        public UserController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpGet]
        public async Task<User> Get()
        {
            return await _usersRepository.GetById(SmartSaver.Domain.Constants.Constants.TestUserId);
        }

        [HttpPut]
        public async Task Put(User user)
        {
            await _usersRepository.Update(SmartSaver.Domain.Constants.Constants.TestUserId, user);
        }

    }
}
