using Autoease.Data.Configuration;
using Autoease.Domain.Entities;
using Autoease.Domain.Entities.Aggregate;
using Microsoft.EntityFrameworkCore;

namespace Autoease.Data.DatabaseContext;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        new UserEntityConfiguration()
            .Configure(modelBuilder.Entity<UserEntity>().ToTable("Users"));

        new GarageEntityConfiguration()
            .Configure(modelBuilder.Entity<GarageEntity>().ToTable("Garage"));

        new AppointmentEntityConfiguration()
            .Configure(modelBuilder.Entity<Appointment>());

        new VeichleEntityConfiguration()
            .Configure(modelBuilder.Entity<Veichle>());
    }

    public DbSet<UserEntity> Users { get; set; }
    public DbSet<GarageEntity> Garages { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Veichle> Veichles { get; set; }
}
