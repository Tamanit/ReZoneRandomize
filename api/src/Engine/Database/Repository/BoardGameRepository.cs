using api.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace api.DataBase.Repository;

public class BoardGameRepository
{
    private DbSet<BoardGameEntity> _context = new AppContext().BoardGames;

    public BoardGameEntity GetRandomGameByBrunch(BrunchEntity brunch) => _context.Where(r => r.BrunchId == brunch.Id).OrderBy(r => Guid.NewGuid()).First();
}
