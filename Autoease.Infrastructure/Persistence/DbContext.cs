using Autoease.Domain.Aggregation;
using Autoease.Domain.Entities;
using Autoease.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Autoease.Infrastructure.Persistence;

public class DatabaseContext : DbContext
{

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>()
            .OwnsOne(a => a.Veichle);

        modelBuilder.Entity<GarageEntity>()
            .OwnsOne(g => g.Address);
    }

    public DbSet<UserEntity> Users { get; set; }
    public DbSet<GarageEntity> Garages { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
}