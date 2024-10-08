namespace MyBlog.Domain.Interfaces;

using Models;

public interface IPostRepository
{
  Task<IEnumerable<Post>> GetAllAsync();
}
