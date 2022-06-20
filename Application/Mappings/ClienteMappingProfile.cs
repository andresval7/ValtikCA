using AutoMapper;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;

namespace ValtikCA.Application.Mappings
{
    public class ClienteMappingProfile: Profile
    {
        public ClienteMappingProfile()
        {
            CreateMap<CreateClienteRequest, Cliente>();
            CreateMap<Cliente, CreateClienteRequest>();
            CreateMap<UpdateClienteRequest, Cliente>();
            CreateMap<Cliente, UpdateClienteRequest>();
            CreateMap<ReadClienteRequest, Cliente>();
            CreateMap<Cliente, ReadClienteRequest>();
            CreateMap<DeleteClienteRequest, Cliente>();
            CreateMap<Cliente, DeleteClienteRequest>();

            CreateMap<Cliente, ClienteResponse>();

        }
    }
}
