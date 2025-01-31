using AutoMapper;
using SimpleStore.API.DTOs;
using SimpleStore.Domain.Models;

namespace SimpleStore.API.Utils
{
    public class SimpleStoreProfile : Profile
    {
        public SimpleStoreProfile() 
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Sale, SaleDTO>().ReverseMap();
            CreateMap<SaleItem, SaleItemDTO>().ReverseMap();
            CreateMap<Supplier, SupplierDTO>().ReverseMap();
        }
    }
}
