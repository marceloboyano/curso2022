namespace DataBase.Repositories
{
    public class GenderRepository : BaseRepository<Gender>, IGenderRepository
    {
        public GenderRepository(DisneyContext context) : base(context)
        {
        }

        
    }
}
