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

        }
    }
}
