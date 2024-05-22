namespace api.DataBase.Entity;

public class DifficultyEntity
{
    //require fields
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    
    //relations
    public List<BoardGameEntity> BoardGames { get; set; }
}
