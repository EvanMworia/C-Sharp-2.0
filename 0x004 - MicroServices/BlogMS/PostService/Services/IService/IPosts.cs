using PostService.Models;
using PostService.Models.DTO_s;

namespace PostService.Services.IService
{
    public interface IPosts
    {
        Task<string> CreatePost(Post createPost);
        Task<string> DeletePost(Post postId);
        Task<string> UpdatePost();
    }
}
