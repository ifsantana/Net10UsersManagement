using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;
using UsersManagement.Api.Models;
using UsersManagement.Api.Repositories;

namespace UsersManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private ConcurrentDictionary<int, User> _users;

        public UsersController(IUserRepository userRepository)
        {
           _users = userRepository.Users;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            if (_users.TryGetValue(id, out var user))
            {
                return Ok(user);
            }
            return NotFound("User not found.");
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (_users.TryAdd(user.Id, user))
            {
                return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
            }
            return Conflict("User with the same ID already exists.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            if (_users.TryRemove(id, out _))
            {
                return NoContent();
            }
            return NotFound("User not found.");
        }
    }
}
