using System;
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
        public async Task<IReadOnlyList<Category>> Get([FromQuery(Name = "per-page")] int perPage = 10, [FromQuery(Name = "page")] int page = 1)
        {
            return await _categoriesRepository.GetAllUserCategories(Domain.Constants.Constants.TestUserId, perPage, page);
        }

        [HttpPost]
        public async Task<Guid> Store(Category category)
        {
            category.UserId = Domain.Constants.Constants.TestUserId;

            return await _categoriesRepository.Create(category);
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<NoContentResult> Delete(Guid id)
        {
            await _categoriesRepository.Delete(id);

            return NoContent();
        }

        [Route("count")]
        [HttpGet]
        public async Task<ActionResult<int>> GetCount()
        {
            return await _categoriesRepository.GetCount(Domain.Constants.Constants.TestUserId);
        }
    }
}
