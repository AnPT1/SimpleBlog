using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MiniBlog2.Entities;

namespace MiniBlog2.Infrastructure
{
    /// <summary>
    /// Main database context (to access storage of the data and the authentication information)
    /// </summary>
    public class SimpleBlogContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categorys { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<UserArticle> UserArticles { get; set; }


        public SimpleBlogContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();
            }
        }
    }
}
