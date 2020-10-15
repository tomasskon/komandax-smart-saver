using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartSaver.Domain.Models;

namespace SmartSaver.Domain.Repositories.Interfaces
{
    public interface IGenericRepository<TModel> where TModel : IdentityModelBase
    {
        Task<Guid> Create(TModel model);

        Task<TModel> GetById(Guid id);

        Task<IReadOnlyList<TModel>> GetAll();

        Task Update(Guid id, TModel model);

        Task Delete(Guid id);
    }
}