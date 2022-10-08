using AutoMapper;
using challenge.QueryFilters;
using challenge.Response;
using challenge.Services;
using DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static challenge.DTOs.Personajes.PersonajeDto;

namespace challenge.Controllers
{
    [Route("GET/character")]
    [ApiController]
    public class PersonajeController : ControllerBase
    {
        private readonly IPersonajeService _personajeService;
        private readonly IMapper _mapper;


        public PersonajeController(IPersonajeService personajeService, IMapper mapper)
        {
            _personajeService = personajeService;
            _mapper = mapper;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetPelicula([FromQuery] PersonajeQueryFilter filters)       
        //{
          
        //    var personajes = await _personajeService.GetPersonajes(filters);            ;
        //    var response = new ApiResponse<IEnumerable<Personaje>>(personajes);
        //    return Ok(response);

        //}

        [HttpGet]
        public async Task<IActionResult> GetPelicula([FromQuery] PersonajeQueryFilter filters)
        {
            var personaje = await _personajeService.GetPersonajes(filters);
            if (personaje.Count() == 0)
            {
                return BadRequest("Los filtros no coinciden con ningun Personaje");
            }

            if (!filters.Detalles)
            {
                var personajeDTO = _mapper.Map<IEnumerable<PersonajeForShowDTO>>(personaje);
                var response = new ApiResponse<IEnumerable<PersonajeForShowDTO>>(personajeDTO);
                return Ok(response);

            }

            return Ok(new ApiResponse<IEnumerable<Personaje>>(personaje));
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> PostPersonaje(PersonajeForCreationDTO personajeDTO)
        {
                     
            await _personajeService.InsertPersonajes(personajeDTO);
            return Ok("Se ha creado el Personaje exitosamente");           
       
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult> PutPersonaje(int id, PersonajeForUpdateDTO personajeDTO)
        {          
            var result = await _personajeService.UpdatePersonajes(id, personajeDTO);
            if (!result) return NotFound("Personaje No Encontrado");
            return Ok("Personaje Modificado con exito");

        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePersonaje(int id)
        {
            
           var result = await _personajeService.DeletePersonajes(id);
            if (!result) return BadRequest("no se encontro el Personaje");           
            return Ok("El personaje ha sido eliminado");
           
        }

    }
}
