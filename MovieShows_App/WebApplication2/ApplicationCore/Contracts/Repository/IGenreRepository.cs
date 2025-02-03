using ApplicationCore.Entities;
using ApplicationCore.Helper;

namespace ApplicationCore.Contracts.Repository;

public interface IGenreRepository: IRepository<Genre>
{
    int GetCount();
    
    PageResultSet<Genre> GetGenresByPages(int pageNumber =1, int pageSize=10);
}