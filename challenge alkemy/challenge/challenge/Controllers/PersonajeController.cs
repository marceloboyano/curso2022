using AutoMapper;
using challenge.DTOs.Personajes;
using challenge.QueryFilters;
using challenge.Response;
using challenge.Services;
using DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static challenge.Controllers.PersonajeController;
using static challenge.DTOs.Personajes.PersonajeDto;

namespace challenge.Controllers
{
    [Route("GET/character")]
    [ApiController]
    public class PersonajeController : Controller
    {
        private readonly IPersonajeService _personajeService;
        private readonly IMapper _mapper;


        public PersonajeController(IPersonajeService personajeService, IMapper mapper)
        {
            _personajeService = personajeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPelicula([FromQuery] PersonajeQueryFilter filters)       
        {
          
            var personajes = await _personajeService.GetPersonajes(filters);            ;
            var response = new ApiResponse<IEnumerable<Personaje>>(personajes);
            return Ok(response);

        }
        [HttpGet]
        [Route("GET/Character/GETALL")]
        public async Task<IActionResult> GetPersonaje()
        {
        
            var personajes= await _personajeService.GetPersonajes();
            var personajeDTO = _mapper.Map <IEnumerable<PersonajeForShowDTO>>(personajes);
            var response = new ApiResponse<IEnumerable<PersonajeForShowDTO>>(personajeDTO);
            return Ok(response);

        }

        [HttpPost]
        public async Task<ActionResult> PostPersonaje(PersonajeForUpdateDTO personajeDTO)
        {
            var personaje = _mapper.Map<Personaje> (personajeDTO);
           
            await _personajeService.InsertPersonajes(personaje);
            personajeDTO = _mapper.Map<PersonajeForUpdateDTO>(personaje);
            var response = new ApiResponse<PersonajeForUpdateDTO>(personajeDTO);
            return Ok(response);

            //context.Personajes.Add(personaje);
            //await _context.SaveChangesAsync();
            //return CreatedAtRoute("/character", new { personaje.PersonajeID }, personaje);
        }

        [HttpPut]
        public async Task<ActionResult> PutPersonaje(int id, PersonajeForUpdateDTO personajeDTO)
        {
            var personaje = _mapper.Map<Personaje>(personajeDTO);
            personaje.PersonajeID = id;

            var result = await _personajeService.UpdatePersonajes(personaje);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
           
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePersonaje(int id)
        {
            
           var result = await _personajeService.DeletePersonajes(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);
           
        }

    }
}
