﻿using System.ComponentModel.DataAnnotations;

namespace Comments.Model.DTOs
{
    public class PostDTO
    {
        public Guid PostId { get; set; }
        public string Subject { get; set; } = string.Empty; 
        public string Content { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
    }
}
