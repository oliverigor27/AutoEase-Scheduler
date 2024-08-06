using Microsoft.EntityFrameworkCore;

namespace Autoease.Data.DatabaseContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
}
