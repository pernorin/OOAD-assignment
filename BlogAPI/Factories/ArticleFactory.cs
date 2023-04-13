using BlogAPI.Models.DTOs;
using BlogAPI.Models.Entities;

namespace BlogAPI.Factories
{
    public class ArticleFactory
    {

        public static ArticleRes CreateArticleRes()
        {
            return new ArticleRes();
        }
        public static ArticleEntity CreateArticleEntity()
        {
            return new ArticleEntity()
            {
                Id = Guid.NewGuid(),
                Published = DateTime.Now
            };
        }
    }
}
