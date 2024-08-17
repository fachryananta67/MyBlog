namespace MyBlog.Domain.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public abstract class ModelBase
{
  protected ModelBase()
  {
    Created = DateTime.Now;
    Updated = DateTime.Now;
    IsActive = true;
  }

  [Key]
  [DatabaseGenerated( DatabaseGeneratedOption.Identity )]
  public int Id { get; set; }

  [Required]
  public DateTime Created { get; set; }

  [Required]
  public DateTime Updated { get; set; }

  [Required]
  public bool IsActive { get; set; }

  public override bool Equals( object obj )
  {
    var @base = obj as ModelBase;
    return @base != null &&
           Id == @base.Id;
  }

  public override int GetHashCode()
  {
    return 1213502048 + Id.GetHashCode();
  }
}