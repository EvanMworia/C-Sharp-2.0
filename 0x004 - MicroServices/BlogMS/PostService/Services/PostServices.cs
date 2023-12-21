using AutoMapper;
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

        public async  Task<string> DeletePost(Post postId)
        {
             _context.Posts.Remove(postId);
            await _context.SaveChangesAsync();
            return "Post Removed";
        }
        public async Task<string> UpdatePost()
        {
            
            await _context.SaveChangesAsync();
            return "Post Updated";
        }
    }
}
