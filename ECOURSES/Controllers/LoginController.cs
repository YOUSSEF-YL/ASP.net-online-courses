using ECOURSES.Data;
using ECOURSES.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ECOURSES.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private readonly ApplicationDbContext _db;
        public LoginController(IConfiguration config, ApplicationDbContext db)
        {
            _config =config;
            _db = db;
        }

        [AllowAnonymous]
        [HttpPost]   
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            var user = Authenticate(userLogin);

            if (user != null)
            {
                var token = Generate(user);
                return Ok(token);
            }
            return NotFound("User not founde");
        }

        private string Generate(User user)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.Role ,user.Role),
                new Claim(ClaimTypes.NameIdentifier ,user.Usename)
            };



            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private User Authenticate(UserLogin userLogin)
        {
            var CuentUser = _db.user.FirstOrDefault(o => o.Usename.ToLower() ==
            userLogin.Usernane.ToLower() && o.Password == userLogin.Passwor);
            if (CuentUser != null)
            {
                return CuentUser;
            }
            return null;
        }
       
    }
}
