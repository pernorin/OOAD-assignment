namespace BlogAPI.Models.Entities
{
    public class ArticleAuthorEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        public ICollection<ArticleEntity> AuthorArticles { get; set; } = null!;
    }
}
