﻿namespace Comments.Model
{
    public class Comment
    {
        public Guid CommentId { get; set; }
        public string CommentBody { get; set; } = string.Empty;
        public Guid PostId { get; set; }
        public string UserName { get; set; } = string.Empty;
    }
}
