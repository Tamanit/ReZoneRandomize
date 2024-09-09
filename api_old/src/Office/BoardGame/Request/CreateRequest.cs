namespace api.Office.BoardGame.Request;

public class CreateRequest
{
    public string name { get; set; }
    public string code { get; set; }
    
    public bool active { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
    public string? rules { get; set; }
    
    public Guid? age_restriction { get; set; }
    public Guid? preview_image { get; set; }
    public List<Guid>? gallery { get; set; }
    public Guid? player_count { get; set; }
    public Guid? difficulty { get; set; }

    public static explicit operator CreateRequest(CreateOrUpdateRequest request)
    {
        return new()
        {
            name = request.name,
            code = request.code,
            active = (bool)request.active,
            description = request.description,
            rules = request.rules,
            age_restriction = request.age_restriction,
            preview_image = request.preview_image,
            gallery = request.gallery,
            player_count = request.player_count,
            difficulty = request.difficulty,
        };
    }
}
