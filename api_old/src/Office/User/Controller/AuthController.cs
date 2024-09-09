using api.DataBase.Repository;
using api.Office.User.Request;
using api.Shared.DtoFactory;
using Microsoft.AspNetCore.Mvc;
using AppContext = api.DataBase.AppContext;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using api.DataBase.Entity;

namespace api.Office.User.Controller;


[ApiController]
[Route("api/v1/")]
public class AuthController : ControllerBase
{
    [HttpPost]
    [Route("register")]
    public IActionResult Register([FromBody] AuthRequest request)
    {
        var user = new UserEntity()
        {
            Id = Guid.NewGuid(),
            Login = request.login,
            Password = request.password
        };
        var db = AppContext.GetInstance();
        db.Users.Add(user);
        db.SaveChanges();
        
        
        var claims = GenerateClaim(user.Id.ToString(), user.Login);
        var jwt = new JwtSecurityToken(claims: claims);
        var token = new JwtSecurityTokenHandler().WriteToken(jwt);

        return Ok(new JwtResponse(){token = token});
    }


[HttpPost]
    [Route("auth")]
    public IActionResult Auth([FromBody] AuthRequest request)
    {
        var db = AppContext.GetInstance();
        var user = db.Users.FirstOrDefault(x => x.Login == request.login && x.Password == request.password);
        if (user != null)
        {

            var claims = GenerateClaim(user.Id.ToString(), user.Login);
            var jwt = new JwtSecurityToken(claims: claims);
            var token = new JwtSecurityTokenHandler().WriteToken(jwt);

            return Ok(new JwtResponse(){token = token});

        }

        return Ok(new JwtResponse(){token = ""});
    }
    
    private static List<Claim> GenerateClaim(string id, string login)
    {
        return new List<Claim>
        {
            new Claim(ClaimTypes.Sid, id),
            new Claim(ClaimTypes.Name, login),
        };
    }

    private class JwtResponse()
    {
        public string token { get; set; }
    }
}