namespace MyBlog.Domain.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Projects")]
public class Project : ModelBase
{
  [Required]
  public string Name { get; set; }
  [Required]
  public string Description { get; set; }
  [Required]
  public string ImageUrl { get; set; }
  [Required]
  public string GitHubUrl { get; set; }
  public string DemoUrl { get; set; }
  [Required]
  public ICollection<string> Tags { get; set; }
  [Required]
  public ICollection<string> Technologies { get; set; }
  [Required]
  public ICollection<string> Features { get; set; }
  public ICollection<string> Screenshots { get; set; }
  
  [ForeignKey("Profile")]
  public int ProfileId { get; set; }
  public Profile Profile { get; set; }
}
