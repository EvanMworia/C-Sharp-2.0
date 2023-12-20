using Auth_Service.Data;
using Auth_Service.Models;
using Auth_Service.Models.DTOs;
using Auth_Service.Services.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Auth_Service.Services
{
    public class UserServices : IUser
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        private readonly UserManager<BlogUser> _user;

        public UserServices(DataContext context, IMapper mapper, UserManager<BlogUser> userManager)
        {
            _dataContext = context;
            _mapper = mapper;
            _user = userManager;
            
        }

        public async Task<LoginResponseDto> Login(LoginRequestDto loginRequest)
        {
            var user = await _dataContext.Users.Where(u => u.UserName.ToLower().Equals(loginRequest.UserName.ToLower())).FirstOrDefaultAsync();
            var isValid = await _user.CheckPasswordAsync(user, loginRequest.Password);

            if (!isValid || user==null)
            {
                return new LoginResponseDto();
            }

            var mappedUser = _mapper.Map<ResponseForRegisteredUserDto>(user);
            
            var response = new LoginResponseDto()
            {
                user = mappedUser,
                Token = " "
            };
            return response;

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

       
    }
}
