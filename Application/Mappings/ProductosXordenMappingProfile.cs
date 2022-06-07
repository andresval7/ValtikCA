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

        }
    }

    
}
