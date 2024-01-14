using Comments.Data;
using Comments.Model;
using Comments.Model.DTOs;
using Comments.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace Comments.Services
{
    public class CommentsServices : IComments
    {
        private readonly ApplicationDbContext _context;
        
        public CommentsServices(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
            
        }

        public async Task<string> AddNewComment(AddCommentDTO commentDTO)
        {
             await _context.AddAsync(commentDTO);
            _context.SaveChanges();
            return "Comment added";
        }

        public Task<List<Comment>> GetCommentsFromPost(Guid PostId)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetSingleComment(Guid CommentId)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RemoveComment(Guid CommentId)
        {
            await _context.Comments.Where(x=> x.CommentId==CommentId).ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
            return "Comment Deleted";
        }
    }
}
