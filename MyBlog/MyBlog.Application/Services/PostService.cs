namespace MyBlog.Application.Services;

using Domain.Interfaces;
using Domain.Models;

public class PostService
{
  private readonly IPostRepository _postRepository;
  
  public PostService( IPostRepository postRepository )
  {
    _postRepository = postRepository;
  }
  
  public async Task<IEnumerable<Post>> GetAllPostsAsync()
  {
    return await _postRepository.GetAllAsync();
  }
}
