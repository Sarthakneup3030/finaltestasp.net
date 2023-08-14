using Microsoft.EntityFrameworkCore;
using finaltest200535820.Models;  // Ensure to include the namespace where Student model is defined

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // DbSet for car
    public DbSet<Car> Cars { get; set; }

}
