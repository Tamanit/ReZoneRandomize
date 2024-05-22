namespace api.DataBase.Entity;

public class PlayerCountEntity
{
    //require fields
    public Guid Id { get; set; }
    public string Text { get; set; }
    
    //relations
    public List<BoardGameEntity> BoardGames { get; set; }
}
