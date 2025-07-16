using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ProductProject.Data;
using ProductProject.Domain.Interface;

namespace ProductProject.Domain.Data
{
    public class ProductRepository<T> : IProductRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public virtual IQueryable<T> GetAll()       
        {
                return _dbSet;
        }
        public Task<List<T>> GetAllSync()
        {
         return _dbSet.ToListAsync();
        }
        public void create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
        public void delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public virtual void SaveChanges()
        {
            _context.SaveChanges();
        }
    }    
}