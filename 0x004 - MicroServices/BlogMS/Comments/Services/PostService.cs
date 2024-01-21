using Comments.Model.DTOs;
using Comments.Services.IServices;
using Newtonsoft.Json;

namespace Comments.Services
{
    public class PostService : IPost
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public PostService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<PostDTO> GetPostById(Guid PostId)
        {
            //Create a Client
            var client = _httpClientFactory.CreateClient("post");
            //send a get request using our client, convert the get request to string
            //the request returns a Response message
            var response= await client.GetAsync(PostId.ToString());
            var content = await response.Content.ReadAsStringAsync();
            var responsedto =  JsonConvert.DeserializeObject<ResponseDTO>(content);
            if (responsedto.Result != null && response.IsSuccessStatusCode)
            {
                JsonConvert.DeserializeObject<PostDTO>(content);
                
            }
            return new PostDTO();
        }   
    }
}
