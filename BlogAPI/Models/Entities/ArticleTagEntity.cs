using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Models.Entities
{
    [Index(nameof(Tag), IsUnique = true)]
    public class ArticleTagEntity
    {
        public int Id { get; set; }
        public string Tag { get; set; } = null!;

        public ICollection<ArticleEntity> TagArticles { get; set; } = null!;
    }
}
