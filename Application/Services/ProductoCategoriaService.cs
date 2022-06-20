using AutoMapper;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.Application.Services
{
    public class ProductoCategoriaService : IProductoCategoriaService
    {
        private readonly IProductoCategoriaService _repository;
        private readonly IMapper _mapper;

        public ProductoCategoriaService(IProductoCategoriaService repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteProductoCategoria(int Id)
        {
            _repository.DeleteProductoCategoria(Id);
        }

        public void DeleteProductoCategoria(string idProducto)
        {
            _repository.DeleteProductoCategoria(idProducto);
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

        public void InsertProductoCategoria(CreateProductoCategoriaRequest idProdcategoria)
        {
            _repository.InsertProductoCategoria(idProdcategoria);
        }

        public void UpdateProductoCategoria(UpdateCategoriaRequest idProdcategoria)
        {
            _repository.UpdateProductoCategoria(idProdcategoria);
        }

        public void UpdateProductoCategoria(UpdateProductoCategoria request)
        {
            _repository.UpdateProductoCategoria(request);
        }
    }
}
