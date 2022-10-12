namespace DataBase.Repositories
{
    public abstract class BusinessEntity
    {
        public abstract int Id { get; }
    }

     public interface IGenericRepository<T> where T : BusinessEntity   
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(int id);
    }

}
