using System.ComponentModel.DataAnnotations;

namespace Auth_Service.Models.DTOs
{
    public class RegisterUserDto
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [EmailAddress] 
        public string EmailAddress { get; set;} = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
