using BlogAPI.Models.DTOs;
using BlogAPI.Repositories;

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

        

        public Task CreateAsync(ArticleReq req)
        {
            var fn = req
        }

        public async Task<IEnumerable<ArticleRes>> GetAllAsync()
        {
            //hämta alla
        }
        public async Task<IEnumerable<ArticleRes>> GetArticlesByType(int id)
        {
            //hämta alla av en typ
        }

    }
}
