namespace DataBase.Repositories
{
    public abstract class BusinessEntity
    {
        public abstract int Id { get; }
    }

    // Con el where T es BusinessEntity forzamos al compilador a reconocer la propiedad Id, esto nos va a servir para implementar un repositorio Base con los métodos de Entity Framework
    public interface IGenericRepository<T> where T : BusinessEntity   
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);  
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }

}
