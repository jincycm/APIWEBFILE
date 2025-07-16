namespace ProductProject.Domain.Interface
{
    public interface IProductRepository <T> where T : class
    {
        Task<List<T>> GetAllSync();

        IQueryable<T> GetAll();

        void create (T entity);
        void update (T entity);
        void delete (T entity);
        void SaveChanges();

    }
}
