using api.DataBase.Entity;

namespace api.Engine.Database.DTO;

public class BoardGameDto(BoardGameEntity entity)
{
    public Guid Id { get; set; } = entity.Id;
    public string Name { get; set; } = entity.Name;
}