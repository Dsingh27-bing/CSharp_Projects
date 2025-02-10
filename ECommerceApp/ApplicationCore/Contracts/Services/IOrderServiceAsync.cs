using ApplicationCore.Model.RequestModels;
using ApplicationCore.Model.ResponseModels;

namespace ApplicationCore.Contracts.Services;

public interface IOrderServiceAsync
{
    Task<IEnumerable<OrderResponseModel>> GetAllAsync();
    Task<IEnumerable<OrderResponseModel>> GetOrderByCustomerId(int customerId);
    Task<OrderResponseModel> GetByIdAsync(int id);

    Task<int> InsertAsync(OrderRequestModel reqModel);
    Task<int> UpdateAsync(OrderRequestModel reqModel);

    Task<int> DeleteByIdAsync(int id);
}