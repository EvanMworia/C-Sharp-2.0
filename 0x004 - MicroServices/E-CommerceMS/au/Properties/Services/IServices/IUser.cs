using Auth_Service.Models.DTOs;

namespace Auth_Service.Services.IServices
{
    public interface IUser
    {
        Task<string> RegisterUser(RegisterUserDto user);

        Task<LoginResponseDto> Login(LoginRequestDto loginRequest);
    }
}
