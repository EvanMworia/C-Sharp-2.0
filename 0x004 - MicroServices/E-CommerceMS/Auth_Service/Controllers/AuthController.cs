using Auth_Service.Models;
using Auth_Service.Models.DTOs;
using Auth_Service.Services.IServices;
using ECommerceMessageBus;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Auth_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUser _userService;
        private readonly IConfiguration _configuration; 
        private readonly UniformResponsesDto _response;
        public AuthController(IUser user, IConfiguration configuration)
        {
            _userService = user;
            _configuration = configuration;
            _response = new UniformResponsesDto();


        }
        [HttpPost]
        public async Task<ActionResult<UserDeets>> RegisterUser(RegisterUserDto registerUser)
        {
            var result = await _userService.RegisterUser(registerUser);
            if (string.IsNullOrWhiteSpace(result))
            {
                _response.Result = "User Registered Successfully";
                // ADD message to queue

                UserMessageDTO message = new UserMessageDTO()
                {
                    UserName= registerUser.UserName,
                    EmailAddress= registerUser.EmailAddress
                };
                var msgbus = new Message();

                //NOTE: Delete This NOte Once You set up the queue name
                await msgbus.PublishMessage(message, _configuration.GetValue<string>("ServiceBus:QueueName"));

                return Created("", _response);
            }

            _response.ErrorMessage = result;
            _response.isSuccess = false;
            return BadRequest(_response);
        }


        [HttpPost("{LoginUser}")]
        public async Task<ActionResult<LoginResponseDto>> LoginUser(LoginRequestDto loginRequest)
        {
            var result = await _userService.Login(loginRequest);

            if (result.user!=null)
            {
                _response.Result = result;
                return Created("", _response);
            }

            _response.ErrorMessage = "Invalid Credentials";
            _response.isSuccess = false;
            return BadRequest(_response);
        }
    }
}