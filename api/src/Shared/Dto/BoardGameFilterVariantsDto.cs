using api.Office.BoardGame.Dto;

namespace api.Shared.Dto;

public class BoardGameFilterVariantsDto
{
    public List<PlayerCountDto> player_count { get; set; }
    public List<DifficultyDto> difficulty { get; set; }

    public BoardGameFilterVariantsDto(
        List<PlayerCountDto> playerCount,
        List<DifficultyDto> difficulty
    )
    {
        this.player_count = playerCount;
        this.difficulty = difficulty;
    }
}