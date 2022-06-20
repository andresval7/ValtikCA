using AutoMapper;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;

namespace ValtikCA.Application.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoService _repository;
        private readonly IMapper _mapper;

        public ProductoService(IProductoService repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteProductoById(Producto producto)
        {
            _repository.DeleteProductoById(producto);
        }

        public void DeleteProductoById(string idProducto)
        {
            _repository.DeleteProductoById(idProducto);
        }

        public IEnumerable<ProductoResponse> GetProducto()
        {
            var productos = _repository.GetProducto();
            var productosResponse = _mapper.Map<IEnumerable<ProductoResponse>>(productos);
            return productosResponse;
        }

        public ProductoResponse GetProductoById(string Id)
        {
            var products = _repository.GetProductoById(Id);
            var productosResponse = _mapper.Map<ProductoResponse>(products);
            return _repository.GetProductoById(Id);
        }

        public void InsertProductoById(CreateProductoRequest producto)
        {
            _repository.InsertProductoById(producto);
        }

        public void UpdateProductoById(UpdateProductoRequest producto)
        {
            _repository.UpdateProductoById(producto);
        }
    }
}
