using api.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace api.DataBase;

public sealed class AppContext: DbContext
{
    public AppContext() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=db;Port=5432;Database=postgres;Username=root;Password=root");
    
    public DbSet<BoardGameEntity> BoardGames { get; set; }
    public DbSet<BrunchEntity> Brunches { get; set; }
}