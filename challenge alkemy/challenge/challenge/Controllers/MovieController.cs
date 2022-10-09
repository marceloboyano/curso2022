using AutoMapper;
using challenge.QueryFilters;
using challenge.Response;
using challenge.Services;
using DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using static challenge.DTOs.Peliculas.MoviesDto;

namespace challenge.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;       

        public MovieController(IMovieService peliculaService, IMapper mapper)
        {
            _movieService = peliculaService;
            _mapper = mapper;
           
        }
       
        [HttpGet]
        public async Task<IActionResult> GetMovie([FromQuery] MovieQueryFilters filters)
        {
            var movies = await _movieService.GetMovies(filters);           
            
            if (!movies.Any())
            {
               return BadRequest("Los filtros no coinciden con ninguna pelicula"); 
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

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> PostMovie(MoviesForCreationDTO movieDTO)
        {
            await _movieService.InsertMovies(movieDTO);

            return Ok("Se ha creado la pelicula exitosamente");
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult> PutMovie(int id, MoviesForUpdateDTO movieDTO)
        {
            var result = await _movieService.UpdateMovies(id, movieDTO);

            if (!result)   return NotFound("Pelicula No Encontrada");

            return Ok("pelicula Modificada con exito");
        }

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
