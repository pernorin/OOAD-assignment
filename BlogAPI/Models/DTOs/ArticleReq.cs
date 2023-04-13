using BlogAPI.Factories;
using BlogAPI.Models.Abstract;
using BlogAPI.Models.Entities;

namespace BlogAPI.Models.DTOs
{
    public class ArticleReq : ArticleAbstract
    {
        public int ContentTypeId { get; set; }
        public string AuthorFirstName { get; set; } = null!;
        public string AuthorLastName { get; set; } = null!;
        public string? Tag { get; set; } 

        /*
        public int ArticleAuthorId { get; set; }
        public int? ArticleTagId { get; set; }
        */

        public static implicit operator ArticleEntity(ArticleReq req)
        {
            var entity = ArticleFactory.CreateArticleEntity();

            
            entity.ArticleTitle = req.ArticleTitle;
            entity.ArticleText = req.ArticleText;
            entity.ContentTypeId = req.ContentTypeId;

            /*
            entity.ArticleAuthorId = req.ArticleAuthorId;
            entity.ArticleTagId = req.ArticleTagId;
            */

            return entity;
        }
    }
}
