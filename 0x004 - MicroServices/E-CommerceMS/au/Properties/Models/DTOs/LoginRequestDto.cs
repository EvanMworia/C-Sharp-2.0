using System.ComponentModel.DataAnnotations;

namespace Auth_Service.Models.DTOs
{
    public class LoginRequestDto
    {
        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

    }
}
