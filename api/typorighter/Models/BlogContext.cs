using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace typorighter.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<BlogPostCategory> BlogPostCategories { get; set; }
        public BlogContext(DbContextOptions<BlogContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.Entity<BlogPostCategory>()
              .HasKey(bpc => new { bpc.BlogPostID, bpc.CategoryID });
          modelBuilder.Entity<BlogPostCategory>()
              .HasOne(bpc => bpc.BlogPost)
              .WithMany(p => p.BlogPostCategories)
              .HasForeignKey(bpc => bpc.BlogPostID);
          modelBuilder.Entity<BlogPostCategory>()
              .HasOne(bpc => bpc.Category)
              .WithMany(c => c.BlogPostCategories)
              .HasForeignKey(bpc => bpc.CategoryID);
        }

  }
}
