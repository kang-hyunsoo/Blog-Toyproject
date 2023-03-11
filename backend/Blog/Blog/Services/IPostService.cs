using System;
using Blog.DTO.Post;
using Domain.Models;

namespace Blog.Services
{
    public interface IPostService
    {
        List<PostDTO> GetPosts();
        PostDTO GetPostById(int postId);
        PostDTO CreatePost(CreatePostDTO newPoset);
        bool UpdatePost(int postId, UpdatePostDTO updatedPost);
        bool DeletePost(int postId);
    }
}

