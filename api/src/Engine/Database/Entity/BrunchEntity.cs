using System.ComponentModel.DataAnnotations.Schema;

namespace api.DataBase.Entity;

public class BrunchEntity
{
    //require fields
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    //non-require fields
    //forein keys
    //relations
    public List<BoardGameEntity>? Commentary { get; set; }
}