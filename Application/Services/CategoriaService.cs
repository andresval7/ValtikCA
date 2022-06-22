using AutoMapper;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;
using ValtikCA.Domain.Interfaces;

namespace ValtikCA.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteCategoria(int idDelete )
        {
            _repository.DeleteCategoriaById(idDelete);
        }

        public IEnumerable<CategoriaResponse> GetAllCategorias()
        {
            var categorias = _repository.GetCategoria();
            var categoriasResponse = _mapper.Map<IEnumerable<CategoriaResponse>>(categorias);
            return categoriasResponse;
        }

        public CategoriaResponse GetCategoriaById(int id)
        {
            var categoria = _repository.GetCategoriaById(id);
            var categoriaResponse = _mapper.Map<CategoriaResponse>(id);
            return categoriaResponse;
        }

        public void InsertCategoriaById(CreateCategoriaRequest request)
        {
            var categoria = _mapper.Map<Categoria>(request);
            _repository.InsertCategoriaById(categoria);
        }

        public void UpdateCategoriaById(UpdateCategoriaRequest request)
        {
            var categoria = _mapper.Map<Categoria>(request);
            _repository.UpdateCategoriaById(categoria);
        }
    }   
}
