namespace Application.IRepositories;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(string id);
    Task AddAsync(T entity);
    void UpdateAsync(T entity);
    void Delete(T entity);
}
