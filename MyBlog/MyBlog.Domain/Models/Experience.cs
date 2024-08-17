namespace MyBlog.Domain.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table( "Experiences" )]
public class Experience : ModelBase
{
  [Required]
  public string Title { get; set; }
  [Required]
  public string Company { get; set; }
  [Required]
  public string Location { get; set; }
  [Required]
  public string Description { get; set; }
  [Required]
  public DateTime StartDate { get; set; }
  public DateTime EndDate { get; set; }
  public ICollection<string> Tags { get; set; }
  
  // Foreign key to Profile
  [ForeignKey( "Profile" )]
  public int ProfileId { get; set; }
  public Profile Profile { get; set; }
}
