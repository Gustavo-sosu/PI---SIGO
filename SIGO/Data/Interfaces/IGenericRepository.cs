namespace SIGO.Data.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T> GetById(int id);
        Task GetByName(string nome);
        Task Add(T entity);
        Task Update(T entity);
        Task Remove(T entity);
        Task<bool> SaveChanges();
    }
}
