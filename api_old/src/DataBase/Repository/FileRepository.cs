using api.Shared.Errors;

namespace api.DataBase.Repository;

public class FileRepository
{
    private AppContext Context = AppContext.GetInstance();
    
    public void Add(Entity.FileEntity entity)
    {
        Context.Files.Add(entity);
        Context.SaveChanges();
    }

    public Entity.FileEntity Get(Guid entityId)
    {
        var entity = Context.Files.Find(entityId);
        if (entity == null) throw new Error(ErrorCode.FileNotFound, 500, "file not found");
        return entity;
    }

    public Entity.FileEntity Fetch(Entity.FileEntity entity)
    {
        var id = entity.Id;
        Context.Files.Update(entity);
        Context.SaveChanges();
        return Context.Files.Find(id) ?? throw new ArgumentNullException();
    }

    public void Remove(Guid entityId)
    {
        Context.Files.Remove(
            Context.Files.Find(entityId) ?? throw new InvalidOperationException()
        );
        Context.SaveChanges();
    }
    
    public List<Entity.FileEntity> GetAll() => Context.Files.ToList();
}