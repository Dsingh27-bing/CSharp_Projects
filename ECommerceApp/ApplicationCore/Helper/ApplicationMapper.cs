using ApplicationCore.Model.RequestModels;
using ApplicationCore.Model.ResponseModels;
using AutoMapper;

namespace ApplicationCore.Helper;

public class ApplicationMapper:Profile
{
    
        public ApplicationMapper()
        {
            CreateMap<Entities.Order, OrderRequestModel>().ReverseMap();
            CreateMap<Entities.Order, OrderResponseModel>().ReverseMap();
        
        }
    
}