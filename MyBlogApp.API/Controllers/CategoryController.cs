using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlogApp.Entities.Dtos;
using MyBlogApp.Services.Abstract;

namespace MyBlogApp.API.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(CategoryListDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAll();
            return Ok(result);
        }

        [HttpGet("[action]byid")]
        [ProducesResponseType(typeof(CategoryDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get([FromQuery] int categoryId)
        {
            var result = await _categoryService.Get(categoryId);
            return Ok(result);
        }
        [HttpGet("[action]")]
        [ProducesResponseType(typeof(CategoryListDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllByNonDeleted()
        {
            var result = await _categoryService.GetAllByNonDeleted();
            return Ok(result);
        }
        [HttpGet("[action]")]
        [ProducesResponseType(typeof(CategoryListDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllByNonDeletedAndActive()
        {
            var result = await _categoryService.GetAllByNonDeletedAndActive();
            return Ok(result);
        }
        [HttpPost]
        [ProducesResponseType(typeof(CategoryAddDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Create([FromForm] CategoryAddDto request, string CreatedName)
        {
            var result = await _categoryService.Add(request, CreatedName);

            return Ok(result);
        }
        [HttpPut]
        [ProducesResponseType(typeof(CategoryUpdateDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Update([FromForm] CategoryUpdateDto request, string ModifiedName)
        {
            var result = await _categoryService.Update(request, ModifiedName);

            return Ok(result);
        }
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> SoftDelete(int categoryId, string modifiedByName)
        {
            var result = await _categoryService.Delete(categoryId, modifiedByName);

            return Ok(result);
        }
        [HttpDelete("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> HardDelete(int categoryId)
        {
            var result = await _categoryService.HardDelete(categoryId);

            return Ok(result);
        }


    }
}
