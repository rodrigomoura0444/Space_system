using Microsoft.EntityFrameworkCore;  // For DbContext and DbSet
using ModelsPOO.Data;

namespace ModelsPOO.models.Data;




    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<YourEntity> YourEntities { get; set; }
    }
}
