using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using ApplicationCore.Helper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GenreRepository: BaseRepository<Genre>, IGenreRepository
{
    private readonly MovieDbContext _movieDbContext;
    public GenreRepository(MovieDbContext dbContext) : base(dbContext)
    {
        _movieDbContext = dbContext;
    }
    public int GetCount()
    {
        return GetAll().Count();
    }

    public PageResultSet<Genre> GetGenresByPages(int pageNumber = 1, int pageSize = 10)
    {
        int count = GetAll().Count();
        var collection = GetAll();
        PageResultSet<Genre> pageResultSet = new PageResultSet<Genre>();
        pageResultSet.PageSize = pageSize;
        pageResultSet.ItemCount = count;
        if (count % pageSize == 0)
        {
            pageResultSet.PageCount = count / pageSize;
        }
        else
        {
            pageResultSet.PageCount = (count / pageSize) + 1;
        }

        pageResultSet.Items = collection.Skip((pageNumber-1) * pageSize).Take(pageSize);
        return pageResultSet;
    }

}