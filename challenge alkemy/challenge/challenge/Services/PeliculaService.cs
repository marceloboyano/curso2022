using challenge.DTOs.Peliculas;
using DataBase.Repositories;

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
    }
}
