using Auth_Service.Models.DTOs;


namespace PostService.Models.DTO_s
{
    public class CreatePostDTO
    {
        public string Subject { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;


        //public UserDeets? PostOwner { get; set; }
        public string UserName { get; set; } = string.Empty;
    }
}
