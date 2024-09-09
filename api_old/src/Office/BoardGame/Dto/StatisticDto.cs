namespace api.Office.BoardGame.Dto;

public class StatisticDto
{
    public List<StatisticElement> difficulty { get; set; }
    public List<StatisticElement> player_count { get; set; }
}