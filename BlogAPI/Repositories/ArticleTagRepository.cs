using BlogAPI.Contexts;
using BlogAPI.Models.DTOs;
using BlogAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Repositories
{
    public class ArticleTagRepository
    {
        private readonly DataContext _context;

        public ArticleTagRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ArticleTagEntity> CreateAsync(ArticleReq req)
        {
            _context.ArticleTags.Add(req);
            await _context.SaveChangesAsync();

            return req;
        }
        public async Task<int> GetAsync(ArticleReq req)
        {
            if(req.Tag != null) { 

                var tag = await _context.ArticleTags.FirstOrDefaultAsync(x => x.Tag == req.Tag);
                if (tag != null)
                {
                    return tag.Id;
                }
                var res = await CreateAsync(req);
                return res.Id;
            }
            return 0;
        }
       
    }
}
