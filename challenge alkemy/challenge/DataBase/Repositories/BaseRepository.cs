using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    /// <summary>
    /// Esta clase implementa un CRUD básico para cualquier entidad de Entity Framework
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepository<T> : IGenericRepository<T> where T : BusinessEntity
    {
        private readonly DisneyContext _context;

        public BaseRepository(DisneyContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<T>> GetAll() => await _context.Set<T>().ToListAsync();

        public async Task<T> GetById(int id) => await _context.Set<T>().FindAsync(id);

        public async Task Create(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
 
        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
