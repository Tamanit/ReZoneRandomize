namespace api.DataBase.Entity;

public class FileEntity
{
    //require fields
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Path { get; set; }
    public string Description { get; set; }

    //relations
    public List<BoardGameEntity> BoardGames;
}
