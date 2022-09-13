using FitnessSystem.Core;
using FitnessSystem.Core.IServices;
using FitnessSystem.Core.Models;
using FitnessSystem.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitnessSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService  _service;

        public CategoryController( ICategoryService service)
        {
            _service = service;
        }

        [HttpGet(Name = "GetAll")]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpPost(Name = "Add")]
        public async Task<IActionResult> AddAsync(CategoryRm rm)
        {
            await _service.Add(rm);
            return Ok();
        }
    }
}
