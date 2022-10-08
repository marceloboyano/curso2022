namespace DataBase.Repositories
{
    public class PersonajesRepository : BaseRepository<Personaje>, IPersonajesRepository
    {
        public PersonajesRepository(DisneyContext context) : base(context)
        {
        }
    }
}
