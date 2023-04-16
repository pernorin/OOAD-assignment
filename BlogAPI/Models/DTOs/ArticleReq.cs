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


            return entity;
        }
        public static implicit operator ArticleAuthorEntity(ArticleReq req)
        {
            var entity = AuthorFactory.CreateAuthorEntity();

            entity.FirstName = req.AuthorFirstName;
            entity.LastName = req.AuthorLastName;

            return entity;
        }
        public static implicit operator ArticleTagEntity(ArticleReq req)
        {
            var entity = TagFactory.CreateTagEntity();
            if (req.Tag != null)
            {

                entity.Tag = req.Tag;
            }

            return entity;

            
        }
    }
}
