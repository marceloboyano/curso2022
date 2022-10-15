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
    [ApiController]
    [Route("api/characters")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly IMapper _mapper;


        public CharacterController(ICharacterService characterService, IMapper mapper)
        {
            _characterService = characterService;
            _mapper = mapper;
        }

        /// <summary>
        /// Busca Personajes aplicando distintos filtros. Se puede Elegir con Detalle o sin el.
        /// </summary>
        /// <param name="filters"></param>
        /// <returns></returns>
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

        
        /// <summary>
        /// Busca Personajes por Id con el Detalle completo.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCharacterById(int id)
        {
            var character = await _characterService.GetCharacterById(id);

            if (character is null)
            {
                return NotFound("No existe personaje para ese id especificado");
            }

            return Ok(new ApiResponse<CharacterForShowWithDetailsDTO>(character));
        }

        /// <summary>
        /// Agregar Personajes.Debe estar previamente registrado, logeado y autorizado con el token. 
        /// </summary>
        /// <param name="characterDTO"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public async Task<ActionResult> PostPersonaje([FromForm] CharacterForCreationDTO characterDTO)
        {
                     
            await _characterService.InsertCharacters(characterDTO);
            return Ok("Se ha creado el Personaje exitosamente");           
       
        }
        /// <summary>
        /// Modificar Personajes, se pueden modificar algunos campos o todos.Debe estar previamente registrado, logeado y autorizado con el token. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="characterDTO"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult> PutPersonaje(int id, [FromForm] CharacterForUpdateDTO characterDTO)
        {          
            var result = await _characterService.UpdateCharacters(id, characterDTO);
            if (!result) return NotFound("Personaje No Encontrado");
            return Ok("Personaje Modificado con exito");

        }
        /// <summary>
        /// Eliminar Personajes.Debe estar previamente registrado, logeado y autorizado con el token.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
