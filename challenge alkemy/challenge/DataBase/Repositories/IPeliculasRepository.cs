namespace DataBase.Repositories
{
    public interface IPeliculasRepository : IGenericRepository<Pelicula>
    {
        public IEnumerable<Pelicula> GetPeliculaConDetalles();
    }
}