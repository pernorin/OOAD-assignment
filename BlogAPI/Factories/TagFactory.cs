using BlogAPI.Models.Entities;

namespace BlogAPI.Factories
{
    public class TagFactory
    {
        public static ArticleTagEntity CreateTagEntity()
        {
            return new ArticleTagEntity();
        }
    }
}
