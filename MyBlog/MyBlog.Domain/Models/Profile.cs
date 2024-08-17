namespace MyBlog.Domain.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table( "Profiles" )]
public class Profile : ModelBase
{
  [Required]
  public string Name { get; set; }
  public string Bio { get; set; }
  public string ProfilePicture { get; set; }
  public string Email { get; set; }
  public string PhoneNumber { get; set; }
  public ICollection<Experience> Experiences { get; set; }
  public ICollection<Project> Projects { get; set; }
  public ICollection<string> Skills { get; set; }
  public ICollection<Post> Posts { get; set; }
}
