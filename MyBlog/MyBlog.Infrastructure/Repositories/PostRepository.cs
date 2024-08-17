namespace MyBlog.Infrastructure.Repositories;

using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

public class PostRepository : IPostRepository
{
  private readonly MyBlogDbContextFactory _contextFactory;

  public PostRepository( MyBlogDbContextFactory contextFactory )
  {
    _contextFactory = contextFactory;
  }

  public async Task<IEnumerable<Post>> GetAllAsync()
  {
    await using var context = _contextFactory.Create();
    
    return await context.Posts.ToListAsync();
  }
}
