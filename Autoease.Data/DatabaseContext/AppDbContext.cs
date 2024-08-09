using Autoease.Domain.Entities;
using Autoease.Domain.Entities.Aggregate;
using Microsoft.EntityFrameworkCore;

namespace Autoease.Data.DatabaseContext;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<GarageEntity> Garages { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Veichle> Veichles { get; set; }
}
