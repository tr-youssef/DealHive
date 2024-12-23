using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Add DbSet for each entity
    // public DbSet<DealHive> Deals { get; set; }
}