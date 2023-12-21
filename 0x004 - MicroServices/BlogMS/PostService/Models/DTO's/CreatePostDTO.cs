using Auth_Service.Models.DTOs;


namespace PostService.Models.DTO_s
{
    public class CreatePostDTO
    {
        public string Subject { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        //Inquire if i should relate them this way or just the other way (commented below)
        public UserDeets? PostOwner { get; set; }
        //public string UserName { get; set; } = string.Empty;
    }
}
