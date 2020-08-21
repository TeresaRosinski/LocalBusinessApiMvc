using Microsoft.EntityFrameworkCore;
namespace Api.Models
{
  public class ApiContext : DbContext
  {
    public ApiContext(DbContextOptions <ApiContext> options)
    : base (options)
    {

    }
    public DbSet <Business> Businesses {get; set;}
  }
}