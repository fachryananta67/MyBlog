namespace MyBlog.Application.Services;

using Domain.Entities;
using Domain.Interfaces;

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
