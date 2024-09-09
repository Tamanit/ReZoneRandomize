using api.Shared.Dto;

namespace api.Office.BoardGame.Dto;

public class BoardGameListingElementDto
{
    public Guid id { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public string detail_link { get; set; }
    public string? title { get; set; }
    public FileDto? preview_image { get; set; }
    public AgeRestrictionDto? age_restriction { get; set; }
    public PlayerCountDto? player_count { get; set; }
    public DifficultyDto? difficulty { get; set; }
    public bool active { get; set; }

    public BoardGameListingElementDto(
        Guid id,
        string name,
        string code,
        bool active,
        string detailLink,
        string? title = null,
        FileDto? previewImage = null,
        AgeRestrictionDto? ageRestriction = null,
        PlayerCountDto? playerCount = null,
        DifficultyDto? difficulty = null
    )
    {
        this.id = id;
        this.name = name;
        this.code = code;
        this.title = title;
        this.preview_image = previewImage;
        this.age_restriction = ageRestriction;
        this.player_count = playerCount;
        this.difficulty = difficulty;
        this.active = active;
        this.detail_link = detailLink;
    }
}
