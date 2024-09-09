using api.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace api.DataBase;

public sealed class AppContext: DbContext
{
    private AppContext()
    {
        Database.EnsureCreated();
    }
    
    public static AppContext GetInstance()
    {
        return new AppContext();
    }
    
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<NoteEntity> Notes { get; set; }
    public DbSet<BoardGameEntity> BoardGames { get; set; }
    public DbSet<CommentaryEntity> Commentaries { get; set; }
    public DbSet<DifficultyEntity> Difficulties { get; set; }
    public DbSet<PermissionEntity> Permissions { get; set; }
    public DbSet<PlayerCountEntity> PlayerCounts { get; set; }
    public DbSet<AgeRestrictionEntity> AgeRestrictions { get; set; }
    public DbSet<FileEntity> Files { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=db;Port=5432;Database=postgres;Username=root;Password=root"
        );
    }
}