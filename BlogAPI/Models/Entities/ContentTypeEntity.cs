namespace BlogAPI.Models.Entities
{
    public class ContentTypeEntity
    {
        public int Id { get; set; }
        public string ContentType { get; set; } = null!;

        public ICollection<ArticleEntity> Articles { get; set; } = null!;
    }
}
