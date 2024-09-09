using api.DataBase.Entity;
using api.DataBase.Repository;
using api.Office.BoardGame.Request;

namespace api.DataBase.EntityFactory;

public class BoardGameEntityFactory
{
    private readonly AgeRestrictionRepository _ageRestrictionRepository = new();
    private readonly FileRepository _fileRepository = new();
    private readonly PlayerCountRepository _playerCountRepository = new();
    private readonly DifficultyRepository _difficultyRepository = new();
    private readonly BoardGameRepository _boardGameRepository = new();
    
    public BoardGameEntity Create(CreateRequest dto)
    {
        var boardGame = new BoardGameEntity()
        {
            Id = Guid.NewGuid(),
            Name = dto.name,
            Code = dto.code,
            CreatedAt = DateTime.Now.ToUniversalTime(),
            UpdateAt = DateTime.Now.ToUniversalTime(),
            Active = dto.active,
            Title = dto.title,
            Description = dto.description,
            Rules = dto.rules,
            AgeRestrictionId = dto.age_restriction,  
            PreviewImageId = dto.preview_image,
            PlayerCountId = dto.player_count,
            DifficultyId = dto.difficulty,
            Notes = null,
            Commentary = null
        };
        
        return boardGame;
    }
    
    public BoardGameEntity Create(UpdateRequest dto)
    {
        var id = dto.id;
        var oldEntity = _boardGameRepository.Get(dto.id);
        
        var boardGame = new BoardGameEntity()
        {
            Id = oldEntity.Id,
            Name = dto.name ?? oldEntity.Name,
            Code = dto.code ?? oldEntity.Code,
            CreatedAt = oldEntity.CreatedAt.ToUniversalTime(),
            UpdateAt = DateTime.Now.ToUniversalTime(),
            Active = dto.active ?? oldEntity.Active,
            Title = dto.title ?? oldEntity.Title,
            Description = dto.description ?? oldEntity.Description,
            Rules = dto.rules ?? oldEntity.Rules,
            AgeRestriction = dto.age_restriction == null 
                ? oldEntity.AgeRestriction
                : _ageRestrictionRepository.Get((Guid)dto.age_restriction),
            PreviewImage = dto.preview_image == null 
                ? oldEntity.PreviewImage
                : _fileRepository.Get((Guid)dto.preview_image),
            Images = dto.gallery == null 
                ? oldEntity.Images
                : dto.gallery.Select(image => _fileRepository.Get(image)).ToList(),
            PlayerCount = dto.player_count == null 
                ? oldEntity.PlayerCount
                : _playerCountRepository.Get((Guid)dto.player_count),
            Difficulty = dto.difficulty == null 
                ? oldEntity.Difficulty
                : _difficultyRepository.Get((Guid)dto.difficulty),
            Notes = oldEntity.Notes,
            Commentary = oldEntity.Commentary
        };
        
        return boardGame;
    }
}