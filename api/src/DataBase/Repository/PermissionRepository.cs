using api.Office.BoardGame.Request;

namespace api.DataBase.Repository;

public class PermissionRepository
{
    private AppContext Context = AppContext.GetInstance();
    
    public void Add(Entity.PermissionEntity entity)
    {
        Context.Permissions.Add(entity);
        Context.SaveChanges();
    }

    public Entity.PermissionEntity? Get(Guid entityId) => Context.Permissions.Find(entityId);

    public Entity.PermissionEntity Fetch(Entity.PermissionEntity entity)
    {
        var id = entity.Id;
        Context.Permissions.Update(entity);
        Context.SaveChanges();
        return Context.Permissions.Find(id) ?? throw new ArgumentNullException();
    }

    public void Remove(Guid entityId)
    {
        Context.Permissions.Remove(
            Context.Permissions.Find(entityId) ?? throw new InvalidOperationException()
        );
        Context.SaveChanges();
    }

    public List<Entity.PermissionEntity> GetByFilters(ListingRequest filters, int? limit, int? offset)
    {
        throw new NotImplementedException();
    }

    public int GetCountByFilters(ListingRequest filters)
    {
        throw new NotImplementedException();
    }

    public List<Entity.PermissionEntity> GetAll()
    {
        throw new NotImplementedException();
    }
}
