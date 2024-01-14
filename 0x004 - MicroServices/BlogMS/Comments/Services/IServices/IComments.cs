using Comments.Model;
using Comments.Model.DTOs;

namespace Comments.Services.IServices
{
    public interface IComments
    {
        public Task<string> AddNewComment(AddCommentDTO commentDTO);
        public Task<string> RemoveComment(Guid CommentId);
        public Task<List<Comment>> GetCommentsFromPost(Guid PostId);
        public Task<Comment> GetSingleComment(Guid CommentId);

    }
}
