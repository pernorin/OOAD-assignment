using BlogAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BlogAPI.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {    
        }

        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<ContentTypeEntity> ContentTypes { get; set; }
        public DbSet<ArticleTagEntity> ArticleTags { get; set; }
        public DbSet<ArticleAuthorEntity> ArticleAuthors { get; set; }

    }
}
