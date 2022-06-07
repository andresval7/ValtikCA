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
    public class ProductoCategoriumMappingProfile : Profile
    {
        public ProductoCategoriumMappingProfile()
        {
            CreateMap<CreateProductoRequest, ProductoCategorium>();
            CreateMap<ProductoCategorium, CreateProductoRequest>();
            CreateMap<UpdateProductoRequest, ProductoCategorium>();
            CreateMap<TblProducto, UpdateProductoRequest>();
            CreateMap<ReadProductoRequest, ProductoCategorium>();
            CreateMap<TblProducto, ReadProductoRequest>();
            CreateMap<DeleteProductoRequest, ProductoCategorium>();
            CreateMap<ProductoCategorium, DeleteProductoRequest>();
        }
    }
}
