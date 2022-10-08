using AutoMapper;
using challenge.DTOs.Peliculas;
using challenge.QueryFilters;
using DataBase;
using DataBase.Repositories;
using System.Linq;
using static challenge.DTOs.Peliculas.PeliculaDTO;

namespace challenge.Services
{
    public class PeliculaService : IPeliculaService
    {
        private readonly IPeliculasRepository _repo;
        private readonly IMapper _mapper;

        public PeliculaService(IPeliculasRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

       
        public Task<IEnumerable<Pelicula>> GetPeliculas(PeliculasQueryFilters filters)
        {
           

            var peliculas = _repo.GetPeliculaConDetalles();
           
            if(filters.Titulo != null)
            {
                peliculas = peliculas.Where(x=> x.Titulo.ToLower().Contains(filters.Titulo.ToLower()));
            }

            if (filters.GeneroID != null)
            {
                peliculas = peliculas.Where(x => x.Generos.Any(g => g.GeneroID == filters.GeneroID));
            }

            if (filters.Orden != null)
            {
                if (filters.Orden.ToLower() == "asc")
                {
                    peliculas = peliculas.OrderBy(x => x.Titulo);
                }
            }

            if (filters.Orden != null)
            {
                if (filters.Orden.ToLower() == "desc")
                {
                    peliculas = peliculas.OrderByDescending(x => x.Titulo);
                }
            }

            return Task.FromResult(peliculas);
        }
        public async Task InsertPeliculas(PeliculaForCreationDTO peliculaDTO)
        {
            var pelicula = _mapper.Map<Pelicula>(peliculaDTO);

            await _repo.Create(pelicula);
        }

        public async Task<bool> UpdatePeliculas(int id, PeliculaForUpdateDTO peliculaDto)
        {
            var peliculaEntity = await _repo.GetById(id);

            if(peliculaEntity is null)
                return false;

            if(peliculaDto.Titulo is not null)
            {
                peliculaEntity.Titulo = peliculaDto.Titulo;
            }

            if (peliculaDto.Imagen is not null)
            {
                peliculaEntity.Imagen = peliculaDto.Imagen;
            }

            if (peliculaDto.Calificacion is not null)
            {
                peliculaEntity.Calificacion = peliculaDto.Calificacion.Value;
            }

            if (peliculaDto.FechaCreacion is not null)
            {
                peliculaEntity.FechaCreacion = peliculaDto.FechaCreacion.Value;
            }

            return await _repo.Update(peliculaEntity);

        }


        public async Task<bool> DeletePeliculas(int id)
        {

            return await _repo.Delete(id);

        }

    }
}
     

