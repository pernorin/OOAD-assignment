using BlogAPI.Models.Entities;

namespace BlogAPI.Factories
{
    public class AuthorFactory
    {
        public static ArticleAuthorEntity CreateAuthorEntity()
        {
            return new ArticleAuthorEntity();
        }
    }
}
