using Hosys.Commons.Contracts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Hosys.Data.Context;

public class ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> opts, 
    IConfiguration configuration
    ) : DbContextBase(opts)
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql(configuration["ConnectionStrings:HosysConnection"]);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Set default schema
        modelBuilder.HasDefaultSchema("hosys");

        // Apply configurations from all IEntityTypeConfiguration<T> implementations in the assembly
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}