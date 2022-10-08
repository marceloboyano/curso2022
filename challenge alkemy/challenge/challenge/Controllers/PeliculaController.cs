using AutoMapper;
using challenge.QueryFilters;
using challenge.Response;
using challenge.Services;
using DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static challenge.DTOs.Peliculas.PeliculaDTO;

namespace challenge.Controllers
{
    [Route("api/movies")]
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


        /// <summary>
        /// No indicar filtros si quiere traer todas las películas.
        /// </summary>
        /// <param name="filters.Detalles">Indicar true para traer todos los datos de la pelicula incluido personajes y genero</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPelicula([FromQuery] PeliculasQueryFilters filters)
        {
            var peliculas = await _peliculaService.GetPeliculas(filters);

            if (!filters.Detalles)
            {
                var peliculaDTO = _mapper.Map<IEnumerable<PeliculaForShowDTO>>(peliculas);
                var response = new ApiResponse<IEnumerable<PeliculaForShowDTO>>(peliculaDTO);
                return Ok(response);
            }

            return Ok(new ApiResponse<IEnumerable<Pelicula>>(peliculas));
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> PostPelicula(PeliculaForCreationDTO peliculaDTO)
        {
            await _peliculaService.InsertPeliculas(peliculaDTO);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutPelicula(int id, PeliculaForUpdateDTO peliculaDTO)
        {
            var result = await _peliculaService.UpdatePeliculas(id, peliculaDTO);

            if (!result)
                return NotFound("Pelicula No Encontrada");

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePelicula(int id)
        {
            var result = await _peliculaService.DeletePeliculas(id);

            if (!result)
                return BadRequest();

            return Ok();
        }

    }
}
