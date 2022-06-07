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
            CreateMap<CreateClienteRequest, TblCliente>();
            CreateMap<TblCliente, CreateClienteRequest>();
            CreateMap<UpdateClienteRequest, TblCliente>();
            CreateMap<TblCliente, UpdateClienteRequest>();
            CreateMap<ReadClienteRequest, TblCliente>();
            CreateMap<TblCliente, ReadClienteRequest>();
            CreateMap<DeleteClienteRequest, TblCliente>();
            CreateMap<TblCliente, DeleteClienteRequest>();

        }
    }
}
