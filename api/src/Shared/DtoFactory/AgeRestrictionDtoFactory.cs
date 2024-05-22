using api.DataBase.Entity;
using api.DataBase.Repository;
using api.Shared.Dto;

namespace api.Shared.DtoFactory;

public class AgeRestrictionDtoFactory
{
    public AgeRestrictionDto Create(AgeRestrictionEntity entity)
    {
        return new AgeRestrictionDto(
            entity.Id,
            entity.Text
        );
    }
    
    public List<AgeRestrictionDto> CreateCollection(List<AgeRestrictionEntity> entities)
    {
        return entities.Select(Create).ToList();
    }
}
