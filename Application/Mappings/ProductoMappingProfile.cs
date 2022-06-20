using AutoMapper;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;

namespace ValtikCA.Application.Mappings
{
    public class ProductoMappingProfile: Profile
    {
        public ProductoMappingProfile()
        {
            CreateMap<CreateProductoRequest, Producto>();
            CreateMap<Producto, CreateProductoRequest>();
            CreateMap<UpdateProductoRequest, Producto>();
            CreateMap<Producto, UpdateProductoRequest>();
            CreateMap<ReadProductoRequest, Producto>();
            CreateMap<Producto, ReadProductoRequest>();
            CreateMap<DeleteProductoRequest, Producto>();
            CreateMap<Producto, DeleteProductoRequest>();

            CreateMap<Producto, ProductoResponse>();

        }
    }
}
