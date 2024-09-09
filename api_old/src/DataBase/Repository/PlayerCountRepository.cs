using api.Office.BoardGame.Request;
using api.Shared.Errors;

namespace api.DataBase.Repository;

public class PlayerCountRepository
{
    private AppContext Context = AppContext.GetInstance();
    
    public void Add(Entity.PlayerCountEntity entity)
    {
        Context.PlayerCounts.Add(entity);
        Context.SaveChanges();
    }

    public Entity.PlayerCountEntity Get(Guid entityId)
    {
        var entity = Context.PlayerCounts.Find(entityId);
        if (entity == null) throw new Error(ErrorCode.PlayerCountNotFound, 500, "mark not found");
        return entity;
    }

    public Entity.PlayerCountEntity Fetch(Entity.PlayerCountEntity entity)
    {
        var id = entity.Id;
        Context.PlayerCounts.Update(entity);
        Context.SaveChanges();
        return Context.PlayerCounts.Find(id) ?? throw new ArgumentNullException();
    }

    public void Remove(Guid entityId)
    {
        Context.PlayerCounts.Remove(
            Context.PlayerCounts.Find(entityId) ?? throw new InvalidOperationException()
        );
        Context.SaveChanges();
    }
    
    public List<Entity.PlayerCountEntity> GetAll() => Context.PlayerCounts.ToList();
}
