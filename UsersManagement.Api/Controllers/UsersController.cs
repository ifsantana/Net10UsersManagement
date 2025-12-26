using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;
using UsersManagement.Api.Models;
using UsersManagement.Api.Repositories;
using UsersManagement.Api.Services;

namespace UsersManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_usersService.ListAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(string id)
        {
            var user = _usersService.GetById(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound("User not found.");
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserDto user)
        {
            var createdUser = _usersService.Create(user);

            if (createdUser != null)
            {
                return CreatedAtAction(nameof(GetUsers), new { id = createdUser.Id }, createdUser);
            }
            return Conflict("User with the same ID already exists.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(string id)
        {
            var user = _usersService.Delete(id);
            if (user)
            {
                return NoContent();
            }
            return NotFound("User not found.");
        }
    }
}
