using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using typorighter.Models;

namespace typorighter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BlogPostsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/BlogPosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BlogPost>>> GetBlogPost()
        {
            //.NET Core lazy loads by default, 'Include' must be used for Data Navigation
            return await _context.BlogPosts.Include(x => x.BlogPostCategories)
                                          .ThenInclude(y => y.Category)
                                          .ToListAsync();
        }

        //GET: api/BlogPosts/Latest
        //Gets the latest 8 posts, sorting by most recent first
        [HttpGet("latest")]
        public async Task<ActionResult<IEnumerable<BlogPost>>> GetRecentBlogPosts()
        {
            return await _context.BlogPosts.FromSqlRaw("SELECT TOP 8 * FROM BlogPosts")
                                          .Include(x => x.BlogPostCategories) 
                                          .ThenInclude(y => y.Category)       
                                          .OrderByDescending(x => x.DatePublished)  //When using Include, must be ordered on server side post-query
                                          .ToListAsync();
        }

        // GET: api/BlogPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BlogPost>> GetBlogPost(int id)
        {
            var blogPost = await _context.BlogPosts.Include(x => x.BlogPostCategories)
                                                  .ThenInclude(y => y.Category)
                                                  .SingleOrDefaultAsync(m => m.ID == id);

            if (blogPost == null)
            {
                return NotFound();
            }

            return blogPost;
        }

        // PUT: api/BlogPosts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBlogPost(int id, BlogPost blogPost)
        {
            if (id != blogPost.ID)
            {
                return BadRequest();
            }

            _context.Entry(blogPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlogPostExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BlogPosts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BlogPost>> PostBlogPost(BlogPost blogPost)
        {
            _context.BlogPosts.Add(blogPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBlogPost", new { id = blogPost.ID }, blogPost);
        }

        // DELETE: api/BlogPosts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BlogPost>> DeleteBlogPost(int id)
        {
            var blogPost = await _context.BlogPosts.FindAsync(id);
            if (blogPost == null)
            {
                return NotFound();
            }

            _context.BlogPosts.Remove(blogPost);
            await _context.SaveChangesAsync();

            return blogPost;
        }

        private bool BlogPostExists(int id)
        {
            return _context.BlogPosts.Any(e => e.ID == id);
        }
    }
}
