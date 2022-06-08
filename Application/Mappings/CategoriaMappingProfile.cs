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
    public class CategoriaMappingProfile: Profile
    {
        public CategoriaMappingProfile()
        {
            CreateMap<CreateCategoriaRequest, Categoria>();
            CreateMap<Categoria, CreateCategoriaRequest>();
            CreateMap<UpdateCategoriaRequest, Categoria>();
            CreateMap<Categoria, UpdateCategoriaRequest>();
            CreateMap<ReadCategoriaRequest, Categoria>();
            CreateMap<Categoria, ReadCategoriaRequest>();
            CreateMap<DeleteCategoriaRequest, Categoria>();
            CreateMap<Categoria, DeleteCategoriaRequest>();

        }
    }
}
