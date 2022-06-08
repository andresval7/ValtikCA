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
    public class OrdenMappingProfile : Profile
    {
        public OrdenMappingProfile()
        {
            CreateMap<CreateOrdenRequest, Orden>();
            CreateMap<Orden, CreateOrdenRequest>();
            CreateMap<UpdateOrdenRequest, Orden>();
            CreateMap<Orden, UpdateOrdenRequest>();
            CreateMap<ReadOrdenRequest, Orden>();
            CreateMap<Orden, ReadOrdenRequest>();
            CreateMap<DeleteOrdenRequest, Orden>();
            CreateMap<Orden, DeleteOrdenRequest>();
        }
    }
}
