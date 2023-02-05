using System;
using Blog.Domain;

namespace Blog.Services
{
    public interface IPostService
    {
        List<Post> GetPosts();
        Post GetPostById(int postId);
        bool UpdatePost(Post UpdatedPost);
        bool DeletePost(int postId);
    }
}

