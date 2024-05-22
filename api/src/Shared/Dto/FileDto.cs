namespace api.Shared.Dto;

public class FileDto
{
    public Guid id { get; set; }
    public string name { get; set; }
    public string type { get; set; }
    public string path { get; set; }
    public string? description { get; set; }

    public FileDto(
        Guid id,
        string name,
        string type,
        string path,
        string description
    ) {
        this.id = id;
        this.name = name;
        this.type = type;
        this.path = path;
        this.description = description;
    }
}
