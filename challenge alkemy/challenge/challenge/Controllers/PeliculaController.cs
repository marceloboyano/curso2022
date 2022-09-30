using DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace challenge.Controllers
{
    [Route("GET/movies")]
    [ApiController]
    public class PeliculaController : Controller
    {
        private readonly DisneyContext _context;
        public record PeliculaDTO(string Imagen, string Titulo, DateTime FechaCreacion);

        public PeliculaController(DisneyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeliculaDTO>>> GetPelicula()
        {
            var peliculas = await _context.Peliculas.ToListAsync();

            var peliculasDTO = peliculas
                .Select(p => new PeliculaDTO(p.Imagen, p.Titulo, p.FechaCreacion)).ToList();
            return peliculasDTO;

        }
    }
}
