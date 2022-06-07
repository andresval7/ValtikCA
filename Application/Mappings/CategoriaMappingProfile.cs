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
            CreateMap<CreateCategoriaRequest, TblCategorium>();
            CreateMap<TblCategorium, CreateCategoriaRequest>();
            CreateMap<UpdateCategoriaRequest, TblCategorium>();
            CreateMap<TblCategorium, UpdateCategoriaRequest>();
            CreateMap<ReadCategoriaRequest, TblCategorium>();
            CreateMap<TblCategorium, ReadCategoriaRequest>();
            CreateMap<DeleteCategoriaRequest, TblCategorium>();
            CreateMap<TblCategorium, DeleteCategoriaRequest>();

        }
    }
}
