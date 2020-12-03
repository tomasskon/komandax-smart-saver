using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartSaver.Domain.Models;

namespace SmartSaver.Domain.Repositories.Interfaces
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {
        Task<IReadOnlyList<Category>> GetAllUserCategories(Guid userId);
    }
}
