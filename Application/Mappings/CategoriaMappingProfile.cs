using AutoMapper;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;

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

            CreateMap<Categoria, CategoriaResponse>();

        }
    }
}
