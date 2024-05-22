using api.DataBase.Entity;
using api.DataBase.Repository;
using api.Office.BoardGame.Dto;

namespace api.Office.BoardGame.DtoFactory;

public class DifficultyDtoFactory
{
    public DifficultyDto Create(DifficultyEntity entity)
    {
        return new DifficultyDto(
            entity.Id,
            entity.Name,
            entity.Code,
            entity.Level
        );
    }
    
    public List<DifficultyDto> CreateCollection(List<DifficultyEntity> difficultyEntities)
    {
        return difficultyEntities.Select(Create).ToList();
    }
}
