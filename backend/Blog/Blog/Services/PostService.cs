using System;
using Blog.DTO.Post;

namespace Blog.Services
{
    public class PostService : IPostService
    {
        private readonly List<PostDTO> _posts;

        public PostService()
        {
            _posts = new List<PostDTO>();
        }

        public List<PostDTO> GetPosts()
        {
            return _posts;
        }

        public PostDTO GetPostById(int postId)
        {
            return _posts.SingleOrDefault(p => p.Id == postId);
        }

        public PostDTO CreatePost(CreatePostDTO newPost)
        {
            var post = new PostDTO()
            {
                Id = _posts.Count + 1,
                Title = newPost.Title,
                Category = newPost.Category,
                Content = newPost.Content,
                CreatedAt = DateTime.UtcNow
            };
            _posts.Add(post);
            return post;
        }

        public bool UpdatePost(UpdatePostDTO updatedPost)
        {
            var oldPost = GetPostById(updatedPost.Id);
            var exists = oldPost is not null;
            if (exists)
            {
                var index = _posts.FindIndex(x => x.Id == updatedPost.Id);
                var updatePost = new PostDTO()
                {
                    Id = updatedPost.Id,
                    Title = updatedPost.Title,
                    Category = updatedPost.Category,
                    Content = updatedPost.Content,
                    CreatedAt = oldPost!.CreatedAt,
                    UpdatedAt = DateTime.UtcNow
                };
                _posts[index] = updatePost;
                return true;
            }
            return false;
        }

        public bool DeletePost(int postId)
        {
            var post = GetPostById(postId);
            if (post is null)
            {
                return false;
            }
            _posts.Remove(post);
            return true;
        }
    }
}

