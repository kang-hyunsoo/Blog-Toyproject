using Blog.Contracts.V1;
using Blog.DTO.Post;
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
    public ActionResult<List<PostDTO>> GetAllPosts()
    {
        return Ok(_postService.GetPosts()); 
    }

    [HttpGet(ApiRoutes.Posts.Get)]
    public ActionResult GetPostById(int postId)
    {
        var post = _postService.GetPostById(postId);
        if (post is null)
        {
            return NotFound();
        }
        return Ok(post);
    }

    [HttpPost(ApiRoutes.Posts.Create)]
    public ActionResult<PostDTO> CreatePost(CreatePostDTO newPost)
    {
        return Ok(_postService.CreatePost(newPost));
    }

    [HttpPut(ApiRoutes.Posts.Update)]
    public ActionResult UpdatePost(int postId, UpdatePostDTO updatePost)
    {
        var result = _postService.UpdatePost(postId, updatePost);
        if (result is true)
        {
            return GetPostById(postId);
        }
        return BadRequest();
    }

    [HttpDelete(ApiRoutes.Posts.Delete)]
    public ActionResult DeletePost(int postId)
    {
        var result = _postService.DeletePost(postId);
        if (result is true)
        {
            return NoContent();
        }
        return BadRequest();
    }
}



