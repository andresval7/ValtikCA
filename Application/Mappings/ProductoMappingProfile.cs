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

        }
    }
}
