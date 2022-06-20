using AutoMapper;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaService _repository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaService repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteCategoriaById(int id)
        {
            _repository.DeleteCategoriaById(id);
        }

        public IEnumerable<CategoriaResponse> GetAllCategorias()
        {
            var categorias = _repository.GetAllCategorias();
            var categoriasResponse = _mapper.Map<IEnumerable<CategoriaResponse>>(categorias);
            return categoriasResponse;
        }

        public CategoriaResponse GetCategoriaById(int id)
        {
            var categoria = _repository.GetCategoriaById(id);
            var categoriaResponse = _mapper.Map<CategoriaResponse>(id);
            return categoriaResponse;
        }

        public void InsertCategoriaById(CreateCategoriaRequest categoria)
        {
            _repository.InsertCategoriaById(categoria);
        }

        public void UpdateCategoriaById(UpdateCategoriaRequest categoria)
        {
             _repository.UpdateCategoriaById(categoria);
        }
    }   
}
