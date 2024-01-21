using Comments.Model.DTOs;

namespace Comments.Services.IServices
{
    public interface IPost
    {
        public Task<PostDTO> GetPostById(Guid PostId);
    }
}
