using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;

namespace Infrastructure.Repository;

public class OrderRepositoryAsync:BaseRepositoryAsync<Order>,IOrderRepositoryAsync
{
    public OrderRepositoryAsync(ECommerceDbContext dbContext) : base(dbContext)
    {
    }
    
}