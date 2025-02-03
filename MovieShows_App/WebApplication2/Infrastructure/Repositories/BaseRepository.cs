using ApplicationCore.Contracts.Repository;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class BaseRepository<T> : IRepository<T> where T : class
{
    private readonly MovieDbContext _movieDbContext;
    public BaseRepository(MovieDbContext movieDbContext)
    {
        _movieDbContext = movieDbContext;
    }

    public T GetById(int id)
    {
        return _movieDbContext.Set<T>().Find(id);
    }
    
    public IQueryable<T> GetAll()
    {
        return _movieDbContext.Set<T>();
    }
    
    public int Insert(T entity)
    {
        _movieDbContext.Set<T>().Add(entity);
        return _movieDbContext.SaveChanges();
    }
    public int Update(T entity)
    {
        _movieDbContext.Set<T>().Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
        return _movieDbContext.SaveChanges();
    }
    public int Delete(int id)
    {
        var result = _movieDbContext.Set<T>().Find(id);
        if (result != null)
        {
            _movieDbContext.Set<T>().Remove(result);
            
        }
        return _movieDbContext.SaveChanges();
    }
    
    public IEnumerable<T> Search(Func<T, bool> predicate)
    {
        return _movieDbContext.Set<T>().Where(predicate);
        
    }
    

}