using System.ComponentModel.DataAnnotations.Schema;

namespace api.DataBase.Entity;

public class BoardGameEntity
{
    //require fields
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
    
    //non-require fields
    //forein keys

    public Guid? BrunchId { get; set; }
    
    //relations
    [ForeignKey("BrunchId")]
    public BrunchEntity? Brunch { get; set; }
}
