using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Models.Entities
{
    [Index(nameof(ContentType), IsUnique = true)]
    public class ContentTypeEntity
    {
        public int Id { get; set; }
        public string ContentType { get; set; } = null!;

        public ICollection<ArticleEntity> Articles { get; set; } = null!;
    }
}
