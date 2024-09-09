using api.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace api.DataBase.Repository;

public class BrunchRepository
{
    private DbSet<BrunchEntity> _context = new AppContext().Brunches;
    
    public BrunchEntity FindByCode(string code) => _context.FirstOrDefault(x => x.Code == code) ?? _context.First();
}