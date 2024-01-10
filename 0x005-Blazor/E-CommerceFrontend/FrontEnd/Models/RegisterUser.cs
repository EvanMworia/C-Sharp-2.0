using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Models
{
    public class RegisterUser
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
