using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using task1API.Models;

namespace task1API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext _context;

        public UsersController(UserContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User("test", "test"));
            return users;
        }
    }
}