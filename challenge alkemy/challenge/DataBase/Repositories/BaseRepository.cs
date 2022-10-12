using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    /// <summary>
    /// Esta clase implementa un CRUD básico para cualquier entidad de Entity Framework
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepository<T> : IGenericRepository<T> where T : BusinessEntity
    {
        protected readonly DisneyContext _context;

        public BaseRepository(DisneyContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<T>> GetAll() => await _context.Set<T>().ToListAsync();


        public async Task<T?> GetById(int id) => await _context.Set<T>().FindAsync(id);            


        public async Task Create(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var currentEntity = await _context.Set<T>().FindAsync(id);
            if (currentEntity != null)
            {
                _context.Set<T>().Remove(currentEntity);
                int rowsAffected = await _context.SaveChangesAsync();
                return rowsAffected > 0;
            }
            return false;

        }

        public async Task<bool> Update(T entity)
        {
            _context.Update(entity);
            var rowsAffected = await _context.SaveChangesAsync();
            return rowsAffected > 0;

        }
    }
}
