using api.Office.BoardGame.Request;

namespace api.DataBase.Repository;

public class NoteRepository
{
    private AppContext Context = AppContext.GetInstance();
    
    public void Add(Entity.NoteEntity entity)
    {
        Context.Notes.Add(entity);
        Context.SaveChanges();
    }

    public Entity.NoteEntity? Get(Guid entityId) => Context.Notes.Find(entityId);

    public Entity.NoteEntity Fetch(Entity.NoteEntity entity)
    {
        var id = entity.Id;
        Context.Notes.Update(entity);
        Context.SaveChanges();
        return Context.Notes.Find(id) ?? throw new ArgumentNullException();
    }

    public void Remove(Guid entityId)
    {
        Context.Notes.Remove(
            Context.Notes.Find(entityId) ?? throw new InvalidOperationException()
        );
        Context.SaveChanges();
    }

    public List<Entity.NoteEntity> GetByFilters(ListingRequest filters, int? limit, int? offset)
    {
        throw new NotImplementedException();
    }

    public int GetCountByFilters(ListingRequest filters)
    {
        throw new NotImplementedException();
    }

    public List<Entity.NoteEntity> GetAll()
    {
        throw new NotImplementedException();
    }
}
