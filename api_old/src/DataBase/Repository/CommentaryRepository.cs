using api.Office.BoardGame.Request;

namespace api.DataBase.Repository;

public class CommentaryRepository
{
    private AppContext Context = AppContext.GetInstance();
    
    public void Add(Entity.CommentaryEntity entity)
    {
        Context.Commentaries.Add(entity);
        Context.SaveChanges();
    }

    public Entity.CommentaryEntity? Get(Guid entityId) => Context.Commentaries.Find(entityId);

    public Entity.CommentaryEntity Fetch(Entity.CommentaryEntity entity)
    {
        var id = entity.Id;
        Context.Commentaries.Update(entity);
        Context.SaveChanges();
        return Context.Commentaries.Find(id) ?? throw new ArgumentNullException();
    }

    public void Remove(Guid entityId)
    {
        Context.Commentaries.Remove(
            Context.Commentaries.Find(entityId) ?? throw new InvalidOperationException()
        );
        Context.SaveChanges();
    }

    public List<Entity.CommentaryEntity> GetByFilters(ListingRequest filters, int? limit, int? offset)
    {
        throw new NotImplementedException();
    }

    public int GetCountByFilters(ListingRequest filters)
    {
        throw new NotImplementedException();
    }

    public List<Entity.CommentaryEntity> GetAll()
    {
        throw new NotImplementedException();
    }
}
