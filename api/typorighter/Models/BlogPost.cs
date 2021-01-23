using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace typorighter.Models
{
    public class BlogPost
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string CoverImageSource { get; set; }
        public DateTime DatePublished { get; set; }
        public ICollection<BlogPostCategory> BlogPostCategories { get; set; }

    }
}
