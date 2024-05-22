namespace api.Office.BoardGame.Dto;

public class DifficultyDto
{
    public Guid id { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public int level { get; set; }

    public DifficultyDto(
        Guid id,
        string name,
        string code,
        int level
    )
    {
        this.id = id;
        this.name = name;
        this.code = code;
        this.level = level;
    }
}
