namespace Comments.Model.DTOs
{
    public class AddCommentDTO
    {
        public Guid PostId { get; set; }
        public string CommentBody { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
    }
}
