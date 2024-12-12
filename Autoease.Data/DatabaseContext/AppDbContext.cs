using System.Reflection;
using Autoease.Data.Configuration;
using Autoease.Domain.AggregateModel.GarageAggregate;
using Autoease.Domain.AggregateModel.UserAggregate;
using Microsoft.EntityFrameworkCore;

namespace Autoease.Data.DatabaseContext;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<GarageEntity> Garages { get; set; } = null!;
    public DbSet<Appointment> Appointments { get; set; } = null!;
    public DbSet<Veichle> Veichles { get; set; } = null!;
}
