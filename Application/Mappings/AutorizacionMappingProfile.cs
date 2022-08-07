using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;

namespace ValtikCA.Application.Mappings
{
    public class AutorizacionMappingProfile : Profile
    {
        public AutorizacionMappingProfile()
        {
            CreateMap<CreateAutorizacionRequest, Autorizaciones>();
            CreateMap<Autorizaciones, CreateProductoRequest>();
            CreateMap<UpdateAutorizacionRequest, Autorizaciones>();
            CreateMap<Autorizaciones, UpdateAutorizacionRequest>();
            
            CreateMap<DeleteAutorizacionRequest, Autorizaciones>();
            CreateMap<Autorizaciones, DeleteAutorizacionRequest>();

            CreateMap<Autorizaciones, AutorizacionResponse>();

        }
    }
}
