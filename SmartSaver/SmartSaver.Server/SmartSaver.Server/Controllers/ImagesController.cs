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

        public ImagesController(IHostEnvironment environment)
        {
            this._environment = environment;
        }
        [HttpGet("{link}")]
        public IActionResult GetImage(string link)
        {
            return PhysicalFile($@"{_environment.ContentRootPath}\wwwroot\images\{link}", "image/png");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] IFormFile image)
        {
            if (image == null || image.Length == 0)
                return BadRequest("Please upload a file.");

            string fileName = image.FileName;
            string extension = Path.GetExtension(fileName);
            string[] allowedExtensions = { ".JPG", ".jpg", ".png", ".bmp" };

            if (!allowedExtensions.Contains(extension))
                return BadRequest("File is not an image");
            string newFileName = $"{Guid.NewGuid()}{extension}";
            string filePath = Path.Combine(_environment.ContentRootPath,"wwwroot","Images", newFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                await image.CopyToAsync(fileStream);
            }
            return Ok($"api/Images/{newFileName}");
        }
    

    }
}
