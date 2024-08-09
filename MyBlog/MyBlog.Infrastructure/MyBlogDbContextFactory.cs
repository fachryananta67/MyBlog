namespace MyBlog.Infrastructure;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class MyBlogDbContextFactory
{
  private readonly string _connectionString;

  public MyBlogDbContextFactory( string connectionString )
  {
    _connectionString = connectionString;
  }
  
  public MyBlogDbContext Create()
  {
    return new MyBlogDbContext( _connectionString );
  }
}
