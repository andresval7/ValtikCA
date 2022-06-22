using AutoMapper;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;
using ValtikCA.Domain.Interfaces;

namespace ValtikCA.Application.Services
{
    public class ProductoCategoriaService : IProductoCategoriaService
    {
        private readonly IProductoCategoriaRepository _repository;
        private readonly IMapper _mapper;

        public ProductoCategoriaService(IProductoCategoriaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteProductoCategoria(int Id)
        {
            _repository.DeleteProductoCategoriaById(Id);
        }


        public IEnumerable<ProductoCategoriaResponse> GetProductoCategoria()
        {
            var idProdcategorias = _repository.GetProductoCategoria();
            var productoCategoriasResponse = _mapper.Map<IEnumerable<ProductoCategoriaResponse>>(idProdcategorias);
            return productoCategoriasResponse;
        }

        public ProductoCategoriaResponse GetProductoCategoriaById(int Id)
        {
            var idProdcategoria = _repository.GetProductoCategoriaById(Id);
            var productoCategoriaResponse = _mapper.Map<ProductoCategoriaResponse>(idProdcategoria);
            return productoCategoriaResponse;
        }

        public void InsertProductoCategoria(CreateProductoCategoriaRequest request)
        {
            var categoria = _mapper.Map<ProductoCategoria>(request);
            _repository.InsertProductoCategoria(categoria);
        }


        public void UpdateProductoCategoria(UpdateProductoCategoria request)
        {
            var categoria = _mapper.Map<ProductoCategoria>(request);
            _repository.UpdateProductoCategoriaById(categoria);
        }
    }
}
