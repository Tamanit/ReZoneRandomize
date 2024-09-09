namespace api.DataBase.Entity;

public class CommentaryEntity
{
    //require fields
    public Guid Id { get; set; }
    public string Text { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdateAt { get; set; }
    public UserEntity UserEntity { get; set; }
    
    //non-require fields
    public bool? Moderated { get; set; }
    public UserEntity? Moderator { get; set; }
    
    //relations
    private BoardGameEntity BoardGamesEntity { get; set; }
}