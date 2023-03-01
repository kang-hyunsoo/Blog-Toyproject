using System;
namespace Blog.DTO.Post
{
    public interface IPostDTO
    {
        public string Title { get; set; } 
        public string Category { get; set; } 
        public string Content { get; set; } 
    }
}

