using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Application.Requests;
using ValtikCA.Infrastructure.Persistence;

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
        }
    }
}
