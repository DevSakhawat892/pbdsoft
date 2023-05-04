using Microsoft.EntityFrameworkCore;
using Sakhawat.Constract.IRepository;
using Sakhawat.Data;
using System.Linq.Expressions;

namespace Sakhawat.Constract.Repository
{
  public class Repository<T> : IRepository<T> where T : class
  {
    private readonly ApplicationContext context;
    internal DbSet<T> dbSet;
    public Repository(ApplicationContext _context)
    {
      context = _context;
      dbSet = context.Set<T>();
    }

    public T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null)
    {
      IQueryable<T> query = dbSet;
      query = query.Where(filter);
      if (includeProperties != null)
      {
        foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
          query = query.Include(includeProp);
        }
      }
      return query.FirstOrDefault();
    }

    public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
    {
      IQueryable<T> query = dbSet;
      if (filter != null)
      {
        query = query.Where(filter);
      }
      query = query.AsQueryable().AsNoTracking();
      if (includeProperties != null)
      {
        foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
          query = query.Include(includeProp);
        }
      }
      return query.ToList();
    }

    public void Add(T entity)
    {
      dbSet.Add(entity);
    }

    public void Remove(T entity)
    {
      dbSet.Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entity)
    {
      dbSet.RemoveRange(entity);
    }
  }
}