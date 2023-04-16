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
            try
            {
                await _articleService.CreateAsync(req);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }    
        }
        
        [HttpGet]
        public async Task<IEnumerable<ArticleRes>> GetAllAsync()
        {
            return await _articleService.GetAllAsync();
        }

        [HttpGet("id")]
        public async Task<ArticleRes> GetArticleAsync(Guid id)
        {
            try
            {
                return await _articleService.GetArticleAsync(id);
            }
            catch
            {
                return null!;
            }
        }


        /*
        [HttpGet("type{id}")]
        public async Task<IEnumerable<ArticleRes>> GetArticlesByType(int id)
        {
            return await _articleService.GetArticlesByType(id);
        }        

        [HttpPut("id")]
        public async Task<IActionResult> UpdateAsync(Guid id)
        {
            return await _articleService.UpdateAsync( id);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            return await _articleService.DeleteAsync(id);
        }
        */
    }
}
