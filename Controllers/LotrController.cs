using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lotr_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LotrController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public LotrController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet(Name = "GetCharacter")]
        public IEnumerable<LotrCharacters> Get()
        {
            return _characterService.GetAllCharacters();
        }

        [HttpPost]
        public IActionResult Post([FromBody] LotrCharacters request)
        {
            if (request == null || string.IsNullOrEmpty(request.Name))
            {
                return BadRequest("Invalid character data.");
            }

            // Add the new character to the list
            _characterService.AddCharacter(request);

            // Return the updated list
            return Ok(_characterService.GetAllCharacters());
        }
    }

}
