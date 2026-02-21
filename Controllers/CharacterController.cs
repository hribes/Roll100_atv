using Microsoft.AspNetCore.Mvc;
using Roll100.DTO;
using Roll100.Entities;
using Roll100.Interfaces.IServices;

namespace Roll100.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _service;

        public CharacterController(ICharacterService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetCharacters()
        {
            List<Character> characters = this._service.GetCharacters();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetCharacterById([FromQuery] int id)
        {
            Character character = this._service.GetCharacterById(id);
            return Ok(character);
        }

        [HttpPost]
        public IActionResult PostCharacter([FromBody] CreateCharacterDTO character)
        {
            this._service.Create(character);
            return Created();
        }
    }
}
