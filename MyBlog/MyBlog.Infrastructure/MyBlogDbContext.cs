namespace MyBlog.Infrastructure;

using Microsoft.EntityFrameworkCore;
using MyBlog.Domain.Entities;

public class MyBlogDbContext : DbContext
{
  private readonly string _connectionString;

  public MyBlogDbContext()
  {
    _connectionString = "Data Source=MyBlog.db";
  }
  public MyBlogDbContext( string connectionString )
  {
    _connectionString = connectionString;
  }
  
  protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
  {
    optionsBuilder.UseSqlite( _connectionString );
  }
  
  public DbSet<Post> Posts { get; set; }
}
