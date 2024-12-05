using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
    {
        return _dbSet.Where(predicate).ToList();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public void AddRange(IEnumerable<T> entities)
    {
        _dbSet.AddRange(entities);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
        _context.SaveChanges();
    }

    public void DeleteRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
        _context.SaveChanges();
    }
}
