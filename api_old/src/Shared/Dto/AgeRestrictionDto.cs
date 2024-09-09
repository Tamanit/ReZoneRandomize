namespace api.Shared.Dto;

public class AgeRestrictionDto
{
    public Guid id { get; set; }
    public string text { get; set; }

    public AgeRestrictionDto(Guid id, string text)
    {
        this.id = id;
        this.text = text;
    }
}
