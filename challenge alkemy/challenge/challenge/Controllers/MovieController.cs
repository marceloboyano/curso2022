using AutoMapper;
using challenge.QueryFilters;
using challenge.Response;
using challenge.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static challenge.DTOs.Peliculas.MoviesDto;

namespace challenge.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;       

        public MovieController(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
           
        }

        /// <summary>
        /// Busca peliculas por Id con el Detalle completo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            var movie = await _movieService.GetMovieById(id);

            if (movie is null)
            {
                return NotFound("No existe pelicula para el id especificado");
            }

            return Ok(new ApiResponse<MoviesForShowWithDetailsDTO>(movie));
        }
       
        /// <summary>
        /// Busca Peliculas aplicando distintos filtros. Se puede Elegir con Detalle o sin el.
        /// </summary>
        /// <param name="filters"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetMovie([FromQuery] MovieQueryFilters filters)
        {
            var movies = await _movieService.GetMovies(filters);           
            
            if (!movies.Any())
            {
               return NotFound("Los filtros no coinciden con ninguna pelicula"); 
            }

            if (!filters.Details)
            {
                var movieDtoForShow = _mapper.Map<IEnumerable<MoviesForShowDTO>>(movies);
                var response = new ApiResponse<IEnumerable<MoviesForShowDTO>>(movieDtoForShow);
                return Ok(response);
            }

            var movieForShowWithDetails = _mapper.Map<IEnumerable<MoviesForShowWithDetailsDTO>>(movies);
            return Ok(new ApiResponse<IEnumerable<MoviesForShowWithDetailsDTO>>(movieForShowWithDetails));
        }
        /// <summary>
        /// Agregar Peliculas.Debe estar previamente registrado, logeado y autorizado con el token. 
        /// </summary>
        /// <param name="movieDTO"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost]
        public async Task<ActionResult> PostMovie([FromForm] MoviesForCreationDTO movieDTO)
        {
            await _movieService.InsertMovies(movieDTO);

            return Ok("Se ha creado la pelicula exitosamente");
        }

        /// <summary>
        /// Modificar Peliculas, se pueden modificar algunos campos o todos.Debe estar previamente registrado, logeado y autorizado con el token. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="movieDTO"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult> PutMovie(int id, [FromForm] MoviesForUpdateDTO movieDTO)
        {
            var result = await _movieService.UpdateMovies(id, movieDTO);

            if (!result)   return NotFound("Pelicula No Encontrada");

            return Ok("pelicula Modificada con exito");
        }

        /// <summary>
        /// Eliminar Peliculas.Debe estar previamente registrado, logeado y autorizado con el token. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMovie(int id)
        {
            var result = await _movieService.DeleteMovies(id);

            if (!result)
                return BadRequest("no se encontro la pelicula");

            return Ok("la pelicula ha sido eliminada");
        }

    }
}
