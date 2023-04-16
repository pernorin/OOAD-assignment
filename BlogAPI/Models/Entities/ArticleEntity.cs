using BlogAPI.Factories;
using BlogAPI.Models.Abstract;
using BlogAPI.Models.DTOs;

namespace BlogAPI.Models.Entities
{

    public class ArticleEntity : ArticleAbstract
    {
        public Guid Id { get; set; }
        
        public DateTime Published { get; set; }

        public int ContentTypeId { get; set; }
        public ContentTypeEntity ContentType { get; set; } = null!;


        public int ArticleAuthorId { get; set; }
        public ArticleAuthorEntity ArticleAuthor { get; set; } = null!;

        public int? ArticleTagId { get; set; }
        public ArticleTagEntity? ArticleTag { get; set; }
        
        public static implicit operator ArticleRes(ArticleEntity entity)
        {
            var res = ArticleFactory.CreateArticleRes();

            res.ArticleTitle = entity.ArticleTitle;
            res.ArticleText = entity.ArticleText;
            res.Published = entity.Published;
            res.Author = entity.ArticleAuthor.FullName;
            //res.Author = "Pelle";
            res.ContentType = entity.ContentType.ContentType;
            //res.ContentType = "Bajs";
            res.Tag = entity.ArticleTag?.Tag;
            return res;

        }

    }
}
