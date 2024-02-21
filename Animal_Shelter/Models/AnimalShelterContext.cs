using Microsoft.EntityFrameworkCore;

namespace Animal_Shelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animals> Animals { get; set; }

    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}