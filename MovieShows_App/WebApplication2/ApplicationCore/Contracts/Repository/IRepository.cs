namespace ApplicationCore.Contracts.Repository;

public interface IRepository <T> where T : class
{
    T GetById(int id);
    IQueryable<T> GetAll();
    int Insert(T entity);
    int Update(T entity);
    int Delete(int id);
    IEnumerable<T> Search(Func<T, bool> predicate);
}