using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace typorighter.Models
{
    public class AppDbContext : IdentityDbContext
    {
        //DbSets
        public DbSet<BlogPost> BlogPosts{ get; set; }
        public DbSet<Category> Categories {get; set; }
        public DbSet<BlogPostCategory> BlogPostCategories { get; set; }
        public DbSet<BlogReader> Readers { get; set; }
        public DbSet<BlogWriter> Writers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          base.OnModelCreating(modelBuilder);

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
