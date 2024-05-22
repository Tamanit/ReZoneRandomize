namespace api.DataBase.Entity;

public class NoteEntity
{
    //require fields
    public Guid Id { get; set; }
    public string Test { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdateAt { get; set; }
    
    //relations
    public UserEntity UserEntity { get; set; }
    public BoardGameEntity BoardGameEntity { get; set; }
}
