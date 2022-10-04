using challenge.DTOs.Peliculas;
using challenge.QueryFilters;
using DataBase;
using DataBase.Repositories;
using System.Linq;

namespace challenge.Services
{
    public class PeliculaService : IPeliculaService
    {
        private readonly IPeliculasRepository _repo;
      

        public PeliculaService(IPeliculasRepository repo)
        {
            _repo = repo;
          
        }

        public async Task<IEnumerable<PeliculaForShowDTO>> GetPeliculas()
        {
            // Traigo la entidad
            var peliculasEntity = await _repo.GetAll();

            // Es responsabilidad del servicio procesar la entidad y mapearla
            // Para el mapeo podés investigar una libreria llamada AutoMapper, aunque hacerla manualmente para pocos atributos no está mal
            var peliculasDTO = peliculasEntity
                .Select(p => new PeliculaForShowDTO(p.Imagen, p.Titulo, p.FechaCreacion));

            return peliculasDTO;
        }
        public async Task<IEnumerable<Pelicula>> GetPeliculas(PeliculasQueryFilters filters)
        {
           


            var peliculas = await _repo.GetAll();
           

            if(filters.Titulo != null)
            {
                peliculas = peliculas.Where(x=> x.Titulo == filters.Titulo);
            }

            if (filters.GeneroID != null)
            {

                peliculas = peliculas.Where(x => x.Generos.Any(g => g.GeneroID == filters.GeneroID));
            }

            if (filters.Orden.ToLower() == "asc")
            {

                peliculas = peliculas.OrderBy(x => x.Titulo);
            }

            if (filters.Orden.ToLower() == "desc")
            {

                peliculas = peliculas.OrderByDescending(x => x.Titulo);
            }

            return peliculas;
        }
    }
     
}
