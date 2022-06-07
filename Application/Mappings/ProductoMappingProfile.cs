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
            CreateMap<CreateProductoRequest, TblProducto>();
            CreateMap<TblProducto, CreateProductoRequest>();
            CreateMap<UpdateProductoRequest, TblProducto>();
            CreateMap<TblProducto, UpdateProductoRequest>();
            CreateMap<ReadProductoRequest, TblProducto>();
            CreateMap<TblProducto, ReadProductoRequest>();
            CreateMap<DeleteProductoRequest, TblProducto>();
            CreateMap<TblProducto, DeleteProductoRequest>();

        }
    }
}
