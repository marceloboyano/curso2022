using AutoMapper;
using challenge.QueryFilters;
using challenge.Response;
using challenge.Services;
using DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static challenge.DTOs.Personajes.CharacterDto;

namespace challenge.Controllers
{
    [Route("api/characters")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly IMapper _mapper;


        public CharacterController(ICharacterService characterService, IMapper mapper)
        {
            _characterService = characterService;
            _mapper = mapper;
        }

       
        [HttpGet]
        public async Task<IActionResult> GetCharacter([FromQuery] CharacterQueryFilter filters)
        {
            var character = await _characterService.GetCharacters(filters);
            if (!character.Any())
            {
                return BadRequest("Los filtros no coinciden con ningun Personaje");
            }

            if (!filters.Details)
            {
                var characterDtoForShow = _mapper.Map<IEnumerable<CharacterForShowDTO>>(character);
                var response = new ApiResponse<IEnumerable<CharacterForShowDTO>>(characterDtoForShow);
                return Ok(response);
            }

            var characterDtoForShowWithDetails = _mapper.Map<IEnumerable<CharacterForShowWithDetailsDTO>>(character);
            return Ok(new ApiResponse<IEnumerable<CharacterForShowWithDetailsDTO>>(characterDtoForShowWithDetails));
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> PostPersonaje(CharacterForCreationDTO characterDTO)
        {
                     
            await _characterService.InsertCharacters(characterDTO);
            return Ok("Se ha creado el Personaje exitosamente");           
       
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult> PutPersonaje(int id, CharacterForUpdateDTO characterDTO)
        {          
            var result = await _characterService.UpdateCharacters(id, characterDTO);
            if (!result) return NotFound("Personaje No Encontrado");
            return Ok("Personaje Modificado con exito");

        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCharacter(int id)
        {
            
           var result = await _characterService.DeleteCharacters(id);
            if (!result) return BadRequest("no se encontro el Personaje");           
            return Ok("El character ha sido eliminado");
           
        }

    }
}
