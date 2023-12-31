using AutoMapper;
using PostService.Models;
using PostService.Models.DTO_s;

namespace PostService.Profiles
{
    public class PostProfiles:Profile
    {
        public PostProfiles()
        {
            CreateMap<Post, CreatePostDTO>().ReverseMap();
            
        }
    }
}
