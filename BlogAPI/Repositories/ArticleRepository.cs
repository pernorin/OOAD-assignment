using BlogAPI.Contexts;
using BlogAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Repositories
{
    public class ArticleRepository
    {
        private readonly DataContext _context;

        public ArticleRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ArticleEntity> CreateAsync(ArticleEntity entity)
        {
            _context.Articles.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
            
        }
        public async Task<IEnumerable<ArticleEntity>> GetAllAsync()
        {
            return await _context.Articles.Include(x => x.ArticleAuthor).Include(x => x.ContentType).Include(x => x.ArticleTag).ToListAsync();
        }

        public async Task<ArticleEntity> GetAsync(Guid id)
        {
            return await _context.Articles.Include(x => x.ArticleAuthor).Include(x => x.ContentType).Include(x => x.ArticleTag).FirstOrDefaultAsync(x => x.Id == id) ?? null!;
        }



        /*
        UpdateAsync
        DeleteAsync
         */
    }
}
