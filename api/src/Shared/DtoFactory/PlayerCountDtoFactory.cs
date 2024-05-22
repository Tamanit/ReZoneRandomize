using api.DataBase.Entity;
using api.DataBase.Repository;
using api.Shared.Dto;

namespace api.Shared.DtoFactory;

public class PlayerCountDtoFactory
{
    public PlayerCountDto Create(PlayerCountEntity entity)
    {
        return new PlayerCountDto(
            entity.Id,
            entity.Text
        );
    }

    public List<PlayerCountDto> CreateCollection(List<PlayerCountEntity> playerCountEntities)
    {
        return playerCountEntities.Select(Create).ToList();
    }
}
