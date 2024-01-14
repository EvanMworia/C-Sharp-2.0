using Comments.Model.DTOs;

namespace Comments.Services.IServices
{
    public interface IPost
    {
        public PostDTO GetPostById(Guid PostId);
    }
}
