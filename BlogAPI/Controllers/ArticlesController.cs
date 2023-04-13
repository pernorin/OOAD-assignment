using BlogAPI.Models.DTOs;
using BlogAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly ArticleService _articleService;

        public ArticlesController(ArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(ArticleReq req)
        {
            // await _articleService.CreateAsync(req);
        }

        [HttpGet]
        public async Task<IEnumerable<ArticleRes>> GetAllAsync()
        {
            return await _articleService.GetAllAsync();
        }

        [HttpGet("type{id}")]
        public async Task<IEnumerable<ArticleRes>> GetArticlesByType(int id)
        {
            return await _articleService.GetArticlesByType(id);
        }
    }
}
