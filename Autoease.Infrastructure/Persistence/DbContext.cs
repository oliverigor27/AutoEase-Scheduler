
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

    public DbSet<User> Users { get; set; }
    public DbSet<Garage> Garages { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
}