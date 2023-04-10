namespace BlogAPI.Models.Entities
{
    public class ArticleTagEntity
    {
        public int Id { get; set; }
        public string Tag { get; set; } = null!;

        public ICollection<ArticleEntity> TagArticles { get; set; } = null!;
    }
}
