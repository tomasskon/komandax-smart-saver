using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories.Interfaces;

namespace SmartSaver.Domain.Repositories
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : IdentityModelBase
    {
        private SmartSaverDataContext Context => new SmartSaverDataContext(new DbContextOptionsBuilder<SmartSaverDataContext>()
            .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SmartSaver;Integrated Security=True").Options);

        protected DbSet<TModel> Set => Context.Set<TModel>();

        public async Task<Guid> Create(TModel model)
        {
            Set.Add(model);
            await Context.SaveChangesAsync();
            Context.Entry(model).State = EntityState.Detached;
            return model.Id;
        }

        public async Task<IReadOnlyList<TModel>> GetAll()
        {
            return await Set.ToListAsync();
        }

        public async Task<TModel> GetById(Guid id)
        {
            return await Set.SingleAsync(m => m.Id == id);
        }

        public async Task Update(Guid id, TModel model)
        {
            model.Id = id;
            Set.Update(model);
            await Context.SaveChangesAsync();
            Context.Entry(model).State = EntityState.Detached;
        }

        public async Task Delete(Guid id)
        {
            var model = await GetById(id);
            Set.Remove(model);
            await Context.SaveChangesAsync();
        }
    }
}