using Backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    
    public class UserController : ControllerBase
    {
        List<User> obj = new List<User>();

        private readonly IConfiguration _config;
        public UserController(IConfiguration config)
        {
            _config = config;
        }

        public void AddUser()
        {
            obj.Add(new User { Username = "user123", Password = "user123" });
        }

        [HttpGet]
        public void GetData()
        {
            System.Diagnostics.Debug.WriteLine("Working");
        }
        
        [HttpPost("Login")]
        public IActionResult Login(User user)
        {
            if (obj.Any(person => person.Username == user.Username && person.Password == user.Password))
            {
                return Ok("Success");
            }
            return Ok("Unsuccessful");
            
        }
    }
}
