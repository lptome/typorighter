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
        [Required]
        public DateTime DatePublished { get; set; }
        [Required]
        public IList<Category> Categories { get; set; }

    }
}
