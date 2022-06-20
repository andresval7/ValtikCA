using AutoMapper;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;

namespace ValtikCA.Application.Mappings
{
    public class ProductoCategoriaMappingProfile : Profile
    {
        public ProductoCategoriaMappingProfile()
        {
            CreateMap<CreateProductoRequest, ProductoCategoria>();
            CreateMap<ProductoCategoria, CreateProductoRequest>();
            CreateMap<UpdateProductoRequest, ProductoCategoria>();
            CreateMap<Producto, UpdateProductoRequest>();
            CreateMap<ReadProductoRequest, ProductoCategoria>();
            CreateMap<Producto, ReadProductoRequest>();
            CreateMap<DeleteProductoRequest, ProductoCategoria>();
            CreateMap<ProductoCategoria, DeleteProductoRequest>();

            CreateMap<ProductoCategoria, ProductoCategoriaResponse>();
        }
    }
}
