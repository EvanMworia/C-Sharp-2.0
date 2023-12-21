using Auth_Service.Models;
using Auth_Service.Models.DTOs;
using System.ComponentModel.DataAnnotations;

namespace PostService.Models
{
    public class Post
    {
        public Guid PostId { get; set; }

        //Later on Might include photo associated with post here, instead of Subject
        public string Subject { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        [Required]
        public UserDeets? PostOwner { get; set; }
        //if not related to the post owner in this way then remember to change and use correct reference, 
        //reference in question is how to get postOwners username from post
            



    }
}
