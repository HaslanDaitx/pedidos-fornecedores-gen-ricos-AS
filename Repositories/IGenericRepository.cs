using System.Linq.Expressions;

public interface IGenericRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    void Add(T entity);
    void AddRange(IEnumerable<T> entities);
    void Update(T entity);
    void Delete(T entity);
    void DeleteRange(IEnumerable<T> entities);
}