using AutoMapper;
using challenge.DTOs.Peliculas;
using challenge.QueryFilters;
using challenge.Response;
using challenge.Services;
using DataBase;
using Microsoft.AspNetCore.Mvc;
using static challenge.DTOs.Peliculas.PeliculaDTO;
using static challenge.DTOs.Personajes.PersonajeDto;

namespace challenge.Controllers
{
    [Route("GET/movies")]
    [ApiController]
    public class PeliculaController : Controller
    {
        private readonly IPeliculaService _peliculaService;
        private readonly IMapper _mapper;

        public PeliculaController(IPeliculaService peliculaService, IMapper mapper)
        {
            _peliculaService = peliculaService;
            _mapper = mapper;
        }
        
        
        [HttpGet]
        public async Task<IActionResult> GetPelicula([FromQuery] PeliculasQueryFilters filters)
        {
            // Para ir a la implmentacion parate sobre getpeliculas y toca Ctrl + F12
            var peliculas = await _peliculaService.GetPeliculas(filters);

          
            var response = new ApiResponse<IEnumerable<Pelicula>>(peliculas);
            return Ok(response);

            // ;ejor devolver un IActionResult. Hay una serie de respuestas que implementan
            // IActionResult como Ok, NotFound, BadRequest, que lo que hacen es 
            // Envolver tu respuesta en formato json y agregarles un status code (200 en el caso de Ok)
            

        }
        [HttpGet]
        [Route("GET/movies/GETALL")]
        public async Task<IActionResult> GetPelicula()
        {
            //Para ir a la implmentacion parate sobre getpeliculas y toca Ctrl + F12
            var peliculas = await _peliculaService.GetPeliculas();
          
            var peliculaDTO = _mapper.Map<IEnumerable<PeliculaForShowDTO>>(peliculas);
            var response = new ApiResponse<IEnumerable<PeliculaForShowDTO>>(peliculaDTO);
            return Ok(response);

            //; ejor devolver un IActionResult. Hay una serie de respuestas que implementan
            //IActionResult como Ok, NotFound, BadRequest, que lo que hacen es
            //Envolver tu respuesta en formato json y agregarles un status code(200 en el caso de Ok)
           

        }


        [HttpPost]
        public async Task<ActionResult> PostPelicula(PeliculaForUpateDTO peliculaDTO)
        {
            var pelicula = _mapper.Map<Pelicula>(peliculaDTO);

            await _peliculaService.InsertPeliculas(pelicula);
            peliculaDTO = _mapper.Map<PeliculaForUpateDTO>(pelicula);
            var response = new ApiResponse<PeliculaForUpateDTO>(peliculaDTO);
            return Ok(response);

            //context.Personajes.Add(personaje);
            //await _context.SaveChangesAsync();
            //return CreatedAtRoute("/character", new { personaje.PersonajeID }, personaje);
        }

        [HttpPut]
        public async Task<ActionResult> PutPelicula(int id, PeliculaForUpateDTO peliculaDTO)
        {
            var pelicula = _mapper.Map<Pelicula>(peliculaDTO);
            pelicula.PeliculaID = id;

            var result = await _peliculaService.UpdatePeliculas(pelicula);
            var response = new ApiResponse<bool>(result);
            return Ok(response);

        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePelicula(int id)
        {

            var result = await _peliculaService.DeletePeliculas(id);
            var response = new ApiResponse<bool>(result);
            return Ok(response);

        }

    }
}
