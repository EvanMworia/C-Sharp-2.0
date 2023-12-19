using Auth_Service.Data;
using Auth_Service.Models;
using Auth_Service.Models.DTOs;
using Auth_Service.Services.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace Auth_Service.Services
{
    public class UserServices : IUser
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        private readonly UserManager<BlogUser> _user;

        public UserServices(DataContext context, Mapper mapper, UserManager<BlogUser> userManager)
        {
            _dataContext = context;
            _mapper = mapper;
            _user = userManager;
            
        }

        

        public async Task<string> RegisterUser(RegisterUserDto user)
        {
            try
            {
                var mappedUser = _mapper.Map<BlogUser>(user);

                var response = await _user.CreateAsync(mappedUser, user.Password);

                if (response.Succeeded)
                {
                    return string.Empty;
                }
                else
                {
                    return response.Errors.FirstOrDefault().Description;
                }

            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }

        public async Task<LoginResponseDto> Login(LoginRequestDto loginRequest)
        {
            throw new NotImplementedException();
        }
    }
}
