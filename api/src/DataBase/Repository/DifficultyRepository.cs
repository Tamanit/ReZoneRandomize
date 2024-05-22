using api.Office.BoardGame.Request;
using api.Shared.Errors;

namespace api.DataBase.Repository;

public class DifficultyRepository
{
    private AppContext Context = AppContext.GetInstance();
    
    public void Add(Entity.DifficultyEntity entity)
    {
        Context.Difficulties.Add(entity);
        Context.SaveChanges();
    }

    public Entity.DifficultyEntity? Get(Guid entityId)
    {
        var entity = Context.Difficulties.Find(entityId);
        if (entity == null) throw new Error(ErrorCode.DifficultyNotFound, 500, "mark not found");
        return entity;
    }

    public Entity.DifficultyEntity Fetch(Entity.DifficultyEntity entity)
    {
        var id = entity.Id;
        Context.Difficulties.Update(entity);
        Context.SaveChanges();
        return Context.Difficulties.Find(id) ?? throw new ArgumentNullException();
    }

    public void Remove(Guid entityId)
    {
        Context.Difficulties.Remove(
            Context.Difficulties.Find(entityId) ?? throw new InvalidOperationException()
        );
        Context.SaveChanges();
    }
    
    public List<Entity.DifficultyEntity> GetAll() => Context.Difficulties.ToList();
}
