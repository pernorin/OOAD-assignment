namespace BlogAPI.Models.Entities
{
    /*
     id
     datum
     artikeltext
     tag? (flera men valfritt?)
     kategori (en -> många) (eller content type)
     författare (många -> många)
     */
    public class ArticleEntity
    {
        public Guid Id { get; set; }
        public string ArticleTitle { get; set; } = null!;
        public string ArticleText { get; set; } = null!;
        public DateTime Published { get; set; }

        public int ContentTypeId { get; set; }
        public ContentTypeEntity ContentType { get; set; } = null!;

        public ICollection<ArticleAuthorEntity> ArticleAuthors { get; set; } = null!;
        public ICollection<ArticleTagEntity>? ArticleTags { get; set; }
    }
}
