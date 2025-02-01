using Microsoft.AspNetCore.Mvc;
using MyGitHubActionProject.API.Models;

namespace MyGitHubActionProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static readonly List<User> Users = new()
        {
            new User { ID = 1, Name = "Burak Arslan", Username = "burakarslan0110", Email = "burakarslan0110@gmail.com" },
            new User { ID = 2, Name = "Deneme", Username = "Deneme", Email = "Deneme@gmail.com" }
        };

        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            return Ok(Users);
        }

        [HttpGet("GetUserById/{id}")] //yeni ekledi�im metod
        public IActionResult GetUserById(int id)
        {
            var user = Users.FirstOrDefault(u => u.ID == id);
            if (user == null)
                return NotFound(new { message = "Kullan�c� bulunamad�." });

            return Ok(user);
        }

    }
}
