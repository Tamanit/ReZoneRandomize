using api.Office.BoardGame.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppContext = api.DataBase.AppContext;

namespace api.Office.BoardGame.Controller;


[ApiController]
[Route("api/v1/office")]
public class StatisticController: ControllerBase
{
    [HttpGet]
    [Route("statistic")]
    public IActionResult GetStats()
    {
        var db = AppContext.GetInstance();
        
        var difficultyStatistic = new List<StatisticElement>();
        foreach (var difficulty in db.Difficulties.Include(difficultyEntity => difficultyEntity.BoardGames).ToArray())
        {
            difficultyStatistic.Add(new StatisticElement()
            {
                id = difficulty.Id,
                name = difficulty.Name,
                count = difficulty.BoardGames.Count
            });
        }
        
        var playerCountStatistic = new List<StatisticElement>();
        foreach (var playerCount in db.PlayerCounts.Include(entity => entity.BoardGames).ToArray())
        {
            playerCountStatistic.Add(new StatisticElement()
            {
                id = playerCount.Id,
                name = playerCount.Text,
                count = playerCount.BoardGames.Count
            });
        }

        return Ok(new StatisticDto()
        {
            difficulty = difficultyStatistic,
            player_count = playerCountStatistic
        });
    }
}
