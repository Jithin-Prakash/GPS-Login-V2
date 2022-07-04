using Login.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Login.Controllers
{
    [ApiController]
    [Route("[controller]")]
    



    public class UserController : ControllerBase
    {
        List<User> obj = new List<User>
            {
                new User { username = "user123", password = "user123" }
            };

        private readonly IConfiguration _config;
        public UserController(IConfiguration config)
        {
            _config = config;
        }


        [HttpGet("login")]
        public void GetData()
        {
            System.Diagnostics.Debug.WriteLine(obj[0].username);
        }

        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            if (obj.Any(person => person.username == user.username && person.password == user.password))
            {
                return Ok("Success");
            }
            else
                return Ok(user);

        }
    }
}
