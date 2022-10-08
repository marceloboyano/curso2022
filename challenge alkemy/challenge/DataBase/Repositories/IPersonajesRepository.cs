namespace DataBase.Repositories
{
    public interface IPersonajesRepository : IGenericRepository<Personaje>
    {
        public IEnumerable<Personaje> GetPersonajeConDetalles();
    }
}