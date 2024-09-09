using api.Office.BoardGame.Request;

namespace api.DataBase.Repository;

public class UserRepository
{
    private AppContext Context = AppContext.GetInstance();
    
    public void Add(Entity.UserEntity entity)
    {
        Context.Users.Add(entity);
        Context.SaveChanges();
    }

    public Entity.UserEntity? Get(Guid entityId) => Context.Users.Find(entityId);

    public Entity.UserEntity Fetch(Entity.UserEntity entity)
    {
        var id = entity.Id;
        Context.Users.Update(entity);
        Context.SaveChanges();
        return Context.Users.Find(id) ?? throw new ArgumentNullException();
    }

    public void Remove(Guid entityId)
    {
        Context.Users.Remove(
            Context.Users.Find(entityId) ?? throw new InvalidOperationException()
        );
        Context.SaveChanges();
    }

    public List<Entity.UserEntity> GetByFilters(ListingRequest filters, int? limit, int? offset)
    {
        throw new NotImplementedException();
    }

    public int GetCountByFilters(ListingRequest filters)
    {
        throw new NotImplementedException();
    }

    public List<Entity.UserEntity> GetAll()
    {
        throw new NotImplementedException();
    }
}
