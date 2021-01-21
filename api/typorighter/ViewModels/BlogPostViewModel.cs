using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using typorighter.Models;

namespace typorighter.ViewModels
{
  public class BlogPostViewModel
  {
    public int ID { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public string Summary { get; set; }
    public string CoverImageSource { get; set; }
    public DateTime DatePublished { get; set; }
    public ICollection<Category> Categories { get; set; }
  }
}
