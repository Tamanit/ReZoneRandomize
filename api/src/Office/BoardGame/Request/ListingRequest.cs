namespace api.Office.BoardGame.Request;

public class ListingRequest
{
    public int page { get; set; }
    public int limit { get; set; }

    public List<Guid>? palyer_count { get; set; }
    public List<Guid>? difficulty { get; set; }

    public ListingRequest()
    {
        page = 1;
        limit = 12;
    }
}