using Microsoft.AspNetCore.Mvc;
using Roll100.DTO;
using Roll100.Entities;
using Roll100.Interfaces.IServices;

namespace Roll100.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            List<User> users = this._service.GetUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById([FromQuery] int id)
        {
            User user = this._service.GetUserById(id);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult PostUser([FromBody] CreateUserDTO user)
        {
            this._service.Create(user);
            return Created();
        }
        
    }
}
