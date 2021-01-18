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
        public BlogContext(DbContextOptions<BlogContext> options):base(options)
        {

        }

        
    }
}
