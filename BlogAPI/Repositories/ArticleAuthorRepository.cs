using BlogAPI.Contexts;
using BlogAPI.Models.DTOs;
using BlogAPI.Models.Entities;

namespace BlogAPI.Repositories
{
    public class ArticleAuthorRepository
    {
        private readonly DataContext _context;

        public ArticleAuthorRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ArticleAuthorEntity> CreateAsync(ArticleReq req)
        {

        }
    }

    
}
