namespace PostService.Models
{
    public class Post
    {
        public Guid PostId { get; set; }

        public string Subject { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;



    }
}
