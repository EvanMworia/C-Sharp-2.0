using Auth_Service.Models;
using Auth_Service.Models.DTOs;
using AutoMapper;

namespace Auth_Service.Profiles
{
    public class AuthProfiles:Profile
    {
        public AuthProfiles()
        {
            CreateMap<RegisterUserDto, BlogUser>();
            CreateMap<ResponseForRegisteredUserDto, BlogUser>().ReverseMap();
        }
    }
}
