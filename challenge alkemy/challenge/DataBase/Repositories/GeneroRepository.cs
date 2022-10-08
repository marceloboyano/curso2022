namespace DataBase.Repositories
{
    public class GeneroRepository : BaseRepository<Genero>, IGeneroRepository
    {
        public GeneroRepository(DisneyContext context) : base(context)
        {
        }

        
    }
}
