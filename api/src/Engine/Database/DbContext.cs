using api.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace api.DataBase;

public sealed class AppContext: DbContext
{
    public AppContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=srv-captain--rezone-database;Port=5432;Database=rezone_db;Username=re_zone;Password=0bd11ada55137b91");
    
    public DbSet<BoardGameEntity> BoardGames { get; set; }
    public DbSet<BrunchEntity> Brunches { get; set; }
}