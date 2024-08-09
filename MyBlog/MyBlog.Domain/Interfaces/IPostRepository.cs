namespace MyBlog.Domain.Interfaces;

using MyBlog.Domain.Entities;

public interface IPostRepository
{
  Task<IEnumerable<Post>> GetAllAsync();
}
