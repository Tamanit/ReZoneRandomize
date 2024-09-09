namespace api.DataBase.Entity;

public class PermissionEntity
{
    //require fields
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    
    //relations
    public List<UserEntity>? Users { get; set; }
}