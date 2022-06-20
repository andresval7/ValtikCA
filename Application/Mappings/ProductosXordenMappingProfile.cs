using AutoMapper;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;

namespace ValtikCA.Application.Mappings
{
    public class ProductoXordenMappingProfile : Profile
    {
        public ProductoXordenMappingProfile()
        {
            CreateMap<CreateProductoXordenRequest, ProductosXorden>();
            CreateMap<ProductosXorden, CreateProductoXordenRequest>();
            CreateMap<UpdateProductoXordenRequest, ProductosXorden>();
            CreateMap<ProductosXorden, UpdateProductoXordenRequest>();
            CreateMap<ReadProductoXordenRequest, ProductosXorden>();
            CreateMap<ProductosXorden, ReadProductoXordenRequest>();
            CreateMap<DeleteProductoXordenRequest, ProductosXorden>();
            CreateMap<ProductosXorden, DeleteProductoXordenRequest>();

            CreateMap<ProductosXorden, ProductoXordenResponse>();

        }
    }

    
}
