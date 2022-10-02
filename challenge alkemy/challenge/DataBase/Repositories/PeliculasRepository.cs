namespace DataBase.Repositories
{
    public class PeliculasRepository : BaseRepository<Pelicula>, IPeliculasRepository
    {
        public PeliculasRepository(DisneyContext context)
            : base(context)
        {

        }
    }
}
