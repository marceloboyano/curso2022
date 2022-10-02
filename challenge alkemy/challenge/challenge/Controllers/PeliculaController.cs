using challenge.DTOs.Peliculas;
using challenge.Services;
using Microsoft.AspNetCore.Mvc;

namespace challenge.Controllers
{
    [Route("GET/movies")]
    [ApiController]
    public class PeliculaController : Controller
    {
        private readonly IPeliculaService _peliculaService;


        public PeliculaController(IPeliculaService peliculaService)
        {
            _peliculaService = peliculaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPelicula()
        {
            var peliculas = await _peliculaService.GetPeliculas();

            // ;ejor devolver un IActionResult. Hay una serie de respuestas que implementan
            // IActionResult como Ok, NotFound, BadRequest, que lo que hacen es 
            // Envolver tu respuesta en formato json y agregarles un status code (200 en el caso de Ok)
            return Ok(peliculas);

        }
    }
}
