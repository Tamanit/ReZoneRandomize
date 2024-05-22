namespace api.Office.BoardGame.Request;

public class CreateOrUpdateRequest
{
    public Guid? id { get; set; }
    public string? name { get; set; }
    public string? code { get; set; }
    
    public bool? active { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
    public string? rules { get; set; }
    
    public Guid? age_restriction { get; set; }
    public Guid? preview_image { get; set; }
    public List<Guid>? gallery { get; set; }
    public Guid? player_count { get; set; }
    public Guid? difficulty { get; set; }
}
