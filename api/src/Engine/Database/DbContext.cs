using api.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace api.DataBase;

public sealed class AppContext: DbContext
{
    public AppContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=srv-captain--rezone-database;Port=5432;Database=re_zone_random;Username=re_zone;Password=60a28d529fbbd3c8");
    
    public DbSet<BoardGameEntity> BoardGames { get; set; }
    public DbSet<BrunchEntity> Brunches { get; set; }
}