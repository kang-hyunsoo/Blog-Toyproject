using System;
using Blog.Domain;

namespace Blog.Services
{
    public class PostService : IPostService
    {
        private readonly List<Post> _posts;

        public PostService()
        {
            _posts = new List<Post>();
        }

        public List<Post> GetPosts()
        {
            return _posts;
        }

        public Post GetPostById(int postId)
        {
            return _posts.SingleOrDefault(p => p.Id == postId);
        }

        public bool UpdatePost(Post UpdatedPost)
        {
            var exists = GetPostById(UpdatedPost.Id) is not null;
            if (exists)
            {
                var index = _posts.FindIndex(x => x.Id == UpdatedPost.Id);
                _posts[index] = UpdatedPost;
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

