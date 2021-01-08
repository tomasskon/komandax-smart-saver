using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSaver.Domain.Models;
using SmartSaver.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Web;

namespace SmartSaver.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IHostEnvironment _environment;
        private readonly IUsersRepository _usersRepository;

        public ImagesController(IHostEnvironment environment, IUsersRepository usersRepository)
        {
            this._environment = environment;
            this._usersRepository = usersRepository;
        }
        [HttpGet("{link}")]
        public IActionResult GetImage(string link)
        {
            var filename = $@"{_environment.ContentRootPath}\wwwroot\images\{link}";

            if (System.IO.File.Exists(filename))
            {
                return PhysicalFile(filename, "image/jpg");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] IFormFile image, [FromForm] Guid userId)
        {
            if (image == null || image.Length == 0)
                return BadRequest("Please upload a file.");
            var user = _usersRepository.GetById(userId);
            if (user == null)
                return BadRequest("User does not exist");

            string fileName = image.FileName;
            string extension = Path.GetExtension(fileName);
            string[] allowedExtensions = { ".JPG", ".jpg" };

            if (!allowedExtensions.Contains(extension))
                return BadRequest("File is not an image");

            string newFileName = $"{userId}.jpg";
            string filePath = Path.Combine(_environment.ContentRootPath,"wwwroot","Images", newFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await image.CopyToAsync(fileStream);
            }
            return Ok($"api/Images/{newFileName}");
        }
    

    }
}
