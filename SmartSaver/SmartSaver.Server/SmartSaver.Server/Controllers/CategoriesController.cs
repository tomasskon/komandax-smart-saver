using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories.Interfaces;

namespace SmartSaver.Server.Controllers
{
    [Route("categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesController(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        [HttpGet]
        public async Task<IReadOnlyList<Category>> Get()
        {
            return await _categoriesRepository.GetAll(); // GetAllUserCategories(Domain.Constants.Constants.TestUserId);
        }
    }
}
