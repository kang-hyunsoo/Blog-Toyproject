using System;
namespace Blog.DTO.Post
{
    public class PostDTO : IPostDTO
    {
        public int Id { get; set; }
        public string Category { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string Content { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = default!;
        public DateTime? UpdatedAt { get; set; }
    }
}

