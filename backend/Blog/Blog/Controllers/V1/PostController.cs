using Blog.Contracts.V1;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[ApiController]
public class PostController : ControllerBase
{
    private readonly IPostService _postService;

    public PostController(IPostService postService)
    {
        _postService = postService;
    }

    [HttpGet(ApiRoutes.Posts.GetAll)]
    public IActionResult GetAllPosts()
    {
        return Ok(_postService.GetPosts()); 
    }

    [HttpGet(ApiRoutes.Posts.Get)]
    public IActionResult GetPostById(int postId)
    {
        var post = _postService.GetPostById(postId);
        if (post is null)
        {
            return NotFound();
        }
        return Ok(post);
    }

    [HttpPost(ApiRoutes.Posts.Create)]
    public string WriteNewPost()
    {

        return "post";
    }

    [HttpPut(ApiRoutes.Posts.Update)]
    public string UpdatePost(int postId)
    {
        return $"{postId}";
    }

    [HttpDelete(ApiRoutes.Posts.Delete)]
    public string DeletePost(int postId)
    {
        return $"{postId}";
    }
}



