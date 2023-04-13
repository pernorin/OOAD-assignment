namespace BlogAPI.Models.Abstract
{
    public abstract class ArticleAbstract
    {
        public string ArticleTitle { get; set; } = null!; 
        public string ArticleText { get; set; } = null!; 
    }
}
