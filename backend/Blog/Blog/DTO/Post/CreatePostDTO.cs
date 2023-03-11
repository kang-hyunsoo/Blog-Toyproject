using System;
namespace Blog.DTO.Post
{
    public class CreatePostDTO : IPostDTO
    {
        public string Title { get; set; } = default!;
        public string Category { get; set; } = default!;
        public string Content { get; set; } = default!;
    }
}

