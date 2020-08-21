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

    protected override void OnModelCreating (ModelBuilder builder) //Seed the Database
    {
      builder.Entity<Business>()
        .HasData(
          new Business {BusinessId = 1, Name = "El Famous", Type = "Restuarant", Description = "Mexican Restaurant", Address = "Rogers Park"}, 
          new Business {BusinessId = 2, Name = "Rockys Tacos",Type = "Restuarant", Description = "Mexican Restaurant", Address = "Rogers Park"},
          new Business {BusinessId = 3, Name = "Paper Source", Type = "Store", Description = "Craft Store", Address = "Evanston"},
          new Business {BusinessId = 4, Name = "Target", Type= "Store" , Description = "Amazing Store", Address = "Rogers Park"});
    }
  }
}