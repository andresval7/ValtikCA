using AutoMapper;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;
using ValtikCA.Domain.Interfaces;

namespace ValtikCA.Application.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;
        private readonly IMapper _mapper;

        public ProductoService(IProductoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteProductoById(string producto)
        {
            _repository.DeleteProductoById(producto);
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
            return productosResponse;
        }

        public void InsertProductoById(CreateProductoRequest request)
        {
            var categoria = _mapper.Map<Producto>(request);
            _repository.InsertProductoById(categoria);
        }

        public void UpdateProductoById(UpdateProductoRequest request)
        {
            var categoria = _mapper.Map<Producto>(request);
            _repository.UpdateProductoById(categoria);
        }
    }
}
