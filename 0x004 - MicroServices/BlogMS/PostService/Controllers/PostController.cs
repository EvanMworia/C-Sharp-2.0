using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PostService.Models;
using PostService.Models.DTO_s;
using PostService.Services.IService;

namespace PostService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPosts _posts;
        private readonly ResponseDTO _response;

        public PostController(IMapper mapper, IPosts posts)
        {
            _mapper = mapper;
            _posts = posts;
            _response = new ResponseDTO();
            
        }

        [HttpPost ("{CreateNewPost}")]
        public async Task<ActionResult<string>> CreateNewPost(CreatePostDTO dto)
        {
            var post = _mapper.Map<Post>(dto);
            var result = await _posts.CreatePost(post);
            _response.Result= result;
            return Created("", _response);

        }

        [HttpPut("{UpdatePost}")]
        public async Task<ActionResult<string>> UpdatePost(Guid PostId)
        {
            var post = await _posts.GetPostById(PostId);
            if (post == null)
            {
               return _response.ErrorMessage = "No Post was found associated with that ID";
            }
            await _posts.UpdatePost();
            return Ok("Post Updated Successfully");

        }

        [HttpDelete("{DeletePost}")]
        public async Task<ActionResult<string>> DeletePost(Guid PostId)
        {
            var post = await _posts.GetPostById(PostId);
            if (post == null)
            {
                return _response.ErrorMessage = "No Post was found associated with that ID";
            }
            await _posts.DeletePost(PostId);
            return Ok("Post Deleted");

        }
        [HttpGet("{GetAllPosts}")]
        public async Task<ActionResult<List<Post>>> GetAllPosts()
        {
           var allPosts = await _posts.GetAllPosts();
            if (allPosts == null)
            {
                return NotFound(_response.ErrorMessage = "No Posts were found");
            }
            return allPosts;
            
        }

    }
}
