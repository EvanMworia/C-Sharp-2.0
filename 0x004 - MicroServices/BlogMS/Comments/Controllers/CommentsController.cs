using AutoMapper;
using Comments.Model;
using Comments.Model.DTOs;
using Comments.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Comments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IComments _commentService;
        private readonly IPost _postService;
        private readonly IMapper _mapper;
        private readonly ResponseDTO _responseDTO;

        public CommentsController(IComments comments, IMapper mapper, IPost postService)
        {
            _commentService = comments;
            _mapper = mapper;
            _responseDTO = new ResponseDTO();
            _postService = postService;
        }
        [HttpGet("{GetSingleComment}")]
        public async Task<ActionResult<ResponseDTO>> GetSingleComment(Guid id)
        {
            var comment = await _commentService.GetSingleComment(id);
            if(comment == null)
            {
                _responseDTO.ErrorMessage = "No Comment was found with that id";
                _responseDTO.IsSuccess = false;
                _responseDTO.Result=new ResponseDTO();
                return NotFound(_responseDTO.ErrorMessage);
            }
            return Ok(comment);
        }

        [HttpGet("{GetCommentsFromPost}")]
        public async Task<ActionResult<List<Comment>>> GetCommentsFromPost( Guid postId) 
        {
            var post = await _postService.GetPostById(postId);

            if (post==null)
            {
                _responseDTO.ErrorMessage = "Post Not Found";
                return NotFound(_responseDTO.ErrorMessage);                
            }
            var list = _commentService.GetCommentsFromPost(postId);
            return Ok(list);
        }
    }
}
