namespace Auth_Service.Models.DTOs
{
    public class LoginResponseDto
    {
        public string Token { get; set; } = string.Empty;

        public UserDeets user { get; set; } = default!;
    }
}
