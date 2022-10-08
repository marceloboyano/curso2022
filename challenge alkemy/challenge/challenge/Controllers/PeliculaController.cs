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


       
        [HttpGet]
        public async Task<IActionResult> GetPelicula([FromQuery] PeliculasQueryFilters filters)
        {
            var peliculas = await _peliculaService.GetPeliculas(filters);
            if (peliculas.Count() == 0)
            {
               return BadRequest("Los filtros no coinciden con ninguna pelicula"); 
            }

            if (!filters.Detalles)
            {
                var peliculaDTO = _mapper.Map<IEnumerable<PeliculaForShowDTO>>(peliculas);
                var response = new ApiResponse<IEnumerable<PeliculaForShowDTO>>(peliculaDTO);
                return Ok(response);
            }

            return Ok(new ApiResponse<IEnumerable<Pelicula>>(peliculas));
        }

  
        [HttpPost]
        public async Task<ActionResult> PostPelicula(PeliculaForCreationDTO peliculaDTO)
        {
            await _peliculaService.InsertPeliculas(peliculaDTO);

            return Ok("Se creado la pelicula exitosamente");
        }

        
        [HttpPut("{id}")]
        public async Task<ActionResult> PutPelicula(int id, PeliculaForUpdateDTO peliculaDTO)
        {
            var result = await _peliculaService.UpdatePeliculas(id, peliculaDTO);

            if (!result)   return NotFound("Pelicula No Encontrada");

            return Ok("pelicula Modificada con exito");
        }

 
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePelicula(int id)
        {
            var result = await _peliculaService.DeletePeliculas(id);

            if (!result)
                return BadRequest("no se encontro la pelicula");

            return Ok("la pelicula ha sido eliminada");
        }

    }
}
