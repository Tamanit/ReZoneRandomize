using api.Shared.Dto;

namespace api.Office.BoardGame.Dto;

public class BoardGameDetailElementDto
{
    public Guid id { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    
    public bool active { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
    public string? rules { get; set; }
    
    public AgeRestrictionDto? age_restriction { get; set; }
    public FileDto? preview_image { get; set; }
    public List<FileDto>? gallery { get; set; }
    public PlayerCountDto? player_count { get; set; }
    public DifficultyDto? difficulty { get; set; }

    public BoardGameDetailElementDto(
        Guid id,
        string name,
        string code,
        bool active,
        string? title = null,
        string? description = null,
        string? rules = null,
        FileDto? previewImage = null,
        List<FileDto>? gallery = null,
        AgeRestrictionDto? ageRestriction = null,
        PlayerCountDto? playerCount = null,
        DifficultyDto? difficulty = null
    )
    {
        this.id = id;
        this.name = name;
        this.code = code;
        this.active = active;
        this.title = title;
        this.preview_image = previewImage;
        this.age_restriction = ageRestriction;
        this.player_count = playerCount;
        this.difficulty = difficulty;
        this.description = description;
        this.rules = rules;
        this.gallery = gallery;
    }
}
