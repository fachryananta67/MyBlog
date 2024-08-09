namespace MyBlog.Controllers;

using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

public class PostController : Controller
{
  private readonly PostService _postService;
  
  public PostController( PostService postService )
  {
    _postService = postService;
  }

  public async Task<IActionResult> Index()
  {
    var posts = await _postService.GetAllPostsAsync();

    return View( posts );
  }
}
