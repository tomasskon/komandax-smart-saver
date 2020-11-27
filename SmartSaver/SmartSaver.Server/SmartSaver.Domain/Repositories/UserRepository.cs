using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories.Interfaces;


namespace SmartSaver.Domain.Repositories
{
    public class UserRepository : GenericRepository<User>, IUsersRepository
    {

    }
}
