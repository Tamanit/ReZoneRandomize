using api.DataBase.Entity;
using api.Office.BoardGame.Request;
using api.Shared.Errors;
using Microsoft.EntityFrameworkCore;

namespace api.DataBase.Repository;

public class BoardGameRepository
{
    private AppContext Context = AppContext.GetInstance();

    public void Add(Entity.BoardGameEntity entity)
    {
        Context.BoardGames.Add(entity);
        Context.SaveChanges();
    }

    public Entity.BoardGameEntity Get(Guid entityId)
    {
        var entity = Context.BoardGames
            .Include(bg => bg.Difficulty)
            .Include(bg => bg.PlayerCount)
            .Include(bg => bg.AgeRestriction)
            .ToList()
            .FirstOrDefault(entity => entity.Id == entityId);
        if (entity == null) throw new Error(ErrorCode.BoardGameNotFound, 500, "mark not found");
        return entity;
    }

    public Entity.BoardGameEntity Fetch(Entity.BoardGameEntity entity)
    {
        var id = entity.Id;
        Context.BoardGames.Update(entity);
        Context.SaveChanges();
        return Context.BoardGames.Find(id) ?? throw new ArgumentNullException();
    }

    public void Remove(Guid entityId)
    {
        Context.BoardGames.Remove(
            Context.BoardGames.Find(entityId) ?? throw new InvalidOperationException()
        );
        Context.SaveChanges();
    }

    private IQueryable<BoardGameEntity> FindByFilters(ListingRequest filters)
    {
        return Context.BoardGames
            .Include(bg => bg.Difficulty)
            .Include(bg => bg.PlayerCount)
            .Include(bg => bg.AgeRestriction)
            .Where(bg =>
                filters.difficulty == null || bg.Difficulty != null && filters.difficulty.Contains(bg.Difficulty.Id)
            )
            .Where(bg =>
                filters.palyer_count == null ||
                bg.PlayerCount != null && filters.palyer_count.Contains(bg.PlayerCount.Id)
            );
    }

    public List<Entity.BoardGameEntity> GetByFilters(ListingRequest request, int limit, int offset)
    {
        return FindByFilters(request)
            .Skip(offset)
            .Take(limit)
            .ToList();
    }

    public int GetCountByFilters(ListingRequest request)
    {
        return FindByFilters(request)
            .Count();
    }

    public List<Entity.BoardGameEntity> GetAll() => Context.BoardGames.Include(bg => bg.Difficulty)
        .Include(bg => bg.PlayerCount)
        .Include(bg => bg.AgeRestriction)
        .ToList();
}