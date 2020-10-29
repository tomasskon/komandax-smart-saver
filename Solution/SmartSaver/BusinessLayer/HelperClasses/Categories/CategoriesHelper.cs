using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories;

namespace SmartSaver.Logic.HelperClasses.Categories
{
    public class CategoriesHelper
    {
        private readonly CategoriesRepository _categoriesRepository;

        public CategoriesHelper(CategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        public async Task<IReadOnlyList<Category>> GetUserCategories(Guid userId)
        {
            return await _categoriesRepository.GetAllUserCategories(userId);
        }

        public async Task AddNewCategory(Category category)
        {
            await _categoriesRepository.Create(category);
        }

        public async Task DeleteUserCategory(Guid categoryId)
        {
            await _categoriesRepository.Delete(categoryId);
        }
    }
}