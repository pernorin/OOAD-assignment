using BlogAPI.Contexts;
using BlogAPI.Factories;
using BlogAPI.Models.DTOs;
using BlogAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

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
            _context.ArticleAuthors.Add(req);
            await _context.SaveChangesAsync();

            return req;
        }

        //public async Task<int> CreateAsync(ArticleReq req)
        //{
        //    _context.ArticleAuthors.Add(req);
        //    var id = await _context.SaveChangesAsync();

        //    return id;
        //}

        public async Task<int> GetAsync(ArticleReq req)
        {
            
            var author = await _context.ArticleAuthors.FirstOrDefaultAsync(x => x.FirstName == req.AuthorFirstName && x.LastName == req.AuthorLastName);
            if (author != null) 
            {
                return author.Id;
            }
            var res = await CreateAsync(req);
            return res.Id;
        }
    }

    
}
