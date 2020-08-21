using Microsoft.EntityFrameworkCore;
namespace BusinessApi.Models
{
  public class BusinessApiContext : DbContext
  {
    public BusinessApiContext(DbContextOptions <BusinessApiContext> options)
    : base (options)
    {

    }
    public DbSet <Business> Businesses {get; set;}
  }
}