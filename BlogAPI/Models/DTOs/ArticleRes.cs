using BlogAPI.Models.Abstract;

namespace BlogAPI.Models.DTOs
{
    public class ArticleRes : ArticleAbstract
    {
        public DateTime Published { get; set; }
        public string ContentType { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string? Tag { get; set; }
    }
}
