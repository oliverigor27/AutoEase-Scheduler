using Autoease.Domain.Aggregation;
using Autoease.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Autoease.Infrastructure.Persistence;

public class DatabaseContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DatabaseContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DatabaseContext"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>()
            .HasOne(a => a.Veichle);
        
        modelBuilder.Entity<UserEntity>()
            .HasOne(u => u.Address);

        modelBuilder.Entity<GarageEntity>()
            .HasOne(g => g.Address);
    }

    public DbSet<UserEntity> Users { get; set; }
    public DbSet<GarageEntity> Garages { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
}