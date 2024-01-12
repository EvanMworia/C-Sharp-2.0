using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PostService.Data;
using PostService.Models;
using PostService.Models.DTO_s;
using PostService.Services.IService;

namespace PostService.Services
{
    public class PostServices : IPosts
    {
        private readonly ApplicationDbContext _context;
        
        

        public PostServices(ApplicationDbContext context)
        {
            _context = context;
            
        }
        public async Task<string> CreatePost(Post createPost)
        {
            await _context.Posts.AddAsync(createPost);
            await _context.SaveChangesAsync();
            return "Post Created";
        }

        public async  Task<string> DeletePost(Guid postId)
        {
             _context.Posts.Where(x => x.PostId == postId).ExecuteDelete();
            await _context.SaveChangesAsync();
            return "Post Removed";
        }

        public async Task<List<Post>> GetAllPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task<Post> GetPostById(Guid postId)
        {


            return await _context.Posts.Where(x => x.PostId == postId).FirstOrDefaultAsync();
            
        }

        public async Task<string> UpdatePost()
        {
            
            await _context.SaveChangesAsync();
            return "Post Updated";
        }
    }
}
