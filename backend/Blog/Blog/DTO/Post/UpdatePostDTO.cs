using System;
namespace Blog.DTO.Post
{
    public class UpdatePostDTO : IPostDTO
    {
        public int Id { get; set; }
        public string Category { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string Content { get; set; } = default!;
    }
}

