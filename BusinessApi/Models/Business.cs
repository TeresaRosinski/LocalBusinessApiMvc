using System.ComponentModel.DataAnnotations;
namespace BusinessApi.Models
{
  public class Business
  {
    public int BusinessId {get; set;}
    [Required]
    [StringLength(50)]
    public string Name {get; set;}
    [Required]
    public string Type {get; set; }
    [Required]
    public string Description {get; set;}
    [Required]
    public string City {get; set;}
    
  }
}