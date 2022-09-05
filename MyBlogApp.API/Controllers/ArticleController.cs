using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlogApp.Entities.Dtos;
using MyBlogApp.Services.Abstract;

namespace MyBlogApp.API.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(ArticleListDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _articleService.GetAll();
            return Ok(result);
        }

        [HttpGet("[action]byid")]
        [ProducesResponseType(typeof(ArticleDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get([FromQuery] int articleId)
        {
            var result = await _articleService.Get(articleId);
            return Ok(result);
        }
        [HttpGet("[action]")]
        [ProducesResponseType(typeof(ArticleListDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllByNonDeleted()
        {
            var result = await _articleService.GetAllByNonDeleted();
            return Ok(result);
        }
        [HttpGet("[action]")]
        [ProducesResponseType(typeof(ArticleListDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllByNonDeletedAndActive()
        {
            var result = await _articleService.GetAllByNonDeletedAndActive();
            return Ok(result);
        }
        [HttpGet("[action]byid")]
        [ProducesResponseType(typeof(ArticleListDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllByCategory(int categoryId)
        {
            var result = await _articleService.GetAllByCategory(categoryId);
            return Ok(result);
        }
        [HttpPost]
        [ProducesResponseType(typeof(ArticleAddDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Create([FromForm] ArticleAddDto request, string CreatedName)
        {
            var result = await _articleService.Add(request, CreatedName);

            return Ok(result);
        }
        [HttpPut]
        [ProducesResponseType(typeof(ArticleUpdateDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Update([FromForm] ArticleUpdateDto request, string ModifiedName)
        {
            var result = await _articleService.Update(request, ModifiedName);

            return Ok(result);
        }
        [HttpDelete]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> SoftDelete(int articleId, string modifiedByName)
        {
            var result = await _articleService.Delete(articleId, modifiedByName);

            return Ok(result);
        }
        [HttpDelete("[action]")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> HardDelete(int articleId)
        {
            var result = await _articleService.HardDelete(articleId);

            return Ok(result);
        }

    }
}
