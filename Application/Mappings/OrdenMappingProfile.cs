using AutoMapper;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;

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

            CreateMap<Orden, OrdenResponse>();
        }
    }
}
