using Comments.Model.DTOs;
using Comments.Services.IServices;

namespace Comments.Services
{
    public class PostService : IPost
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public PostService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public PostDTO GetPostById(Guid PostId)
        {
            throw new NotImplementedException();
        }
    }
}
