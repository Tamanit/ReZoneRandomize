using Microsoft.EntityFrameworkCore;

namespace api.DataBase.Entity;

[Index(nameof(Login), IsUnique = true)]
public class UserEntity
{
    //require fields
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    
    //relations
    public List<PermissionEntity> Permissions { get; set; }
}
