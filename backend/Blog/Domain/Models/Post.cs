using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; } = default!;
        public string Content { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = default!;
        public DateTime? UpdatedAt { get; set; }
    }
}

