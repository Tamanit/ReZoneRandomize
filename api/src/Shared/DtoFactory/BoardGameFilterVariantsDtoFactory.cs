using api.Office.BoardGame.Dto;
using api.Shared.Dto;

namespace api.Shared.DtoFactory;

public class BoardGameFilterVariantsDtoFactory
{
    public BoardGameFilterVariantsDto Create(
        List<PlayerCountDto> playerCountDto,
        List<DifficultyDto> difficultyDto
    )
    {
        return new BoardGameFilterVariantsDto(
            playerCountDto,
            difficultyDto
            );
    }
}
