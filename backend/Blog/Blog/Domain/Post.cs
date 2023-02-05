namespace Blog.Domain
{
    public class Post
    {
        public int Id { get; set; }
        public string Category { get; set; } = default!;
        public string Content { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = default!;
        public DateTime? UpdatedAt { get; set; }
    }
}

