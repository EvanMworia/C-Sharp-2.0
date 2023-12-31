using PostService.Models;
using PostService.Models.DTO_s;

namespace PostService.Services.IService
{
    public interface IPosts
    {
        Task<string> CreatePost(Post createPost);
        Task<string> DeletePost(Guid postId);
        Task<string> UpdatePost();
        public Task<Post> GetPostById(Guid postId);
    }
}
