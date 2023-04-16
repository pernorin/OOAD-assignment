using BlogAPI.Factories;
using BlogAPI.Models.DTOs;
using BlogAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Services
{
    public class ArticleService
    {
        private readonly ArticleRepository _articleRepo;
        private readonly ArticleAuthorRepository _authorRepo;
        private readonly ArticleTagRepository _tagRepo;
        private readonly ContentTypeRepository _contentTypeRepo;

        public ArticleService(ArticleRepository articleRepo, ArticleAuthorRepository authorRepo, ArticleTagRepository tagRepo, ContentTypeRepository contentTypeRepo)
        {
            _articleRepo = articleRepo;
            _authorRepo = authorRepo;
            _tagRepo = tagRepo;
            _contentTypeRepo = contentTypeRepo;
        }

        

        public async Task CreateAsync(ArticleReq req)
        {   
            var tagId = await _tagRepo.GetAsync(req);
            var authorId = await _authorRepo.GetAsync(req);

            var entity = ArticleFactory.CreateArticleEntity();

            entity.ArticleTitle = req.ArticleTitle;
            entity.ArticleText = req.ArticleText;
            entity.ContentTypeId = req.ContentTypeId;
            //entity.ArticleAuthorId = await _authorRepo.GetAsync(req);
            entity.ArticleAuthorId = authorId;

            if (tagId != 0)
            {
                entity.ArticleTagId = tagId;
            }

            await _articleRepo.CreateAsync(entity);
        }

        
        public async Task<IEnumerable<ArticleRes>> GetAllAsync()
        {
            var articles = ArticleFactory.CreateArticleList();
            var res = await _articleRepo.GetAllAsync();
            foreach(var i in res)
            {
                ArticleRes article = i;
                articles.Add(article);
            }
            return articles;
        }

        public async Task<ArticleRes> GetArticleAsync(Guid id)
        {
            return await _articleRepo.GetAsync(id);
        }


        /*
        public async Task<IEnumerable<ArticleRes>> GetArticlesByType(int id)
        {
            //hämta alla av en typ
        }
        public async Task UpdateAsync(Guid id) //IActionResult ?
        {
            //uppdatera artikel
        }
        public async Task DeleteAsync(Guid id) //IActionResult ?
        {
            //ta bort
        }
        */
    }
}
