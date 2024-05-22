namespace api.Shared.Dto;

public class PlayerCountDto
{
    public Guid id { get; set; }
    public string text { get; set; }

    public PlayerCountDto(Guid id, string text)
    {
        this.id = id;
        this.text = text;
    }
}
