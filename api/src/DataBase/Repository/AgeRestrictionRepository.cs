using api.Shared.Errors;

namespace api.DataBase.Repository;

public class AgeRestrictionRepository
{
    private AppContext Context = AppContext.GetInstance();
    
    public void Add(Entity.AgeRestrictionEntity entity)
    {
        Context.AgeRestrictions.Add(entity);
        Context.SaveChanges();
    }

    public Entity.AgeRestrictionEntity Get(Guid entityId)
    {
        var entity = Context.AgeRestrictions.Find(entityId);
        if (entity == null) throw new Error(ErrorCode.AgeRestrictionNotFound, 500, "mark not found");
        return entity;
    }

    public Entity.AgeRestrictionEntity Fetch(Entity.AgeRestrictionEntity entity)
    {
        var id = entity.Id;
        Context.AgeRestrictions.Update(entity);
        Context.SaveChanges();
        return Context.AgeRestrictions.Find(id) ?? throw new ArgumentNullException();
    }

    public void Remove(Guid entityId)
    {
        Context.AgeRestrictions.Remove(
            Context.AgeRestrictions.Find(entityId) ?? throw new InvalidOperationException()
        );
        Context.SaveChanges();
    }
    
    public List<Entity.AgeRestrictionEntity> GetAll() => Context.AgeRestrictions.ToList();
}
