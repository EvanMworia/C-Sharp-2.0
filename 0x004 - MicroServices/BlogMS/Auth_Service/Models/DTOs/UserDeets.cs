using System.ComponentModel.DataAnnotations;

namespace Auth_Service.Models.DTOs
{
    public class UserDeets
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        
        public string EmailAddress { get; set; } = string.Empty;
      
        
    }
}
