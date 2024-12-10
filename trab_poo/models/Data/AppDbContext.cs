using Microsoft.EntityFrameworkCore;  // For DbContext and DbSet
using ModelsPOO.models.Data;

namespace ModelsPOO.models.Data;




public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
    }

    // Define your DbSets (tables) here
    //public DbSet<YourEntity> YourEntities { get; set; }
}
