using AutoMapper;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;
using ValtikCA.Domain.Interfaces;

namespace ValtikCA.Application.Services
{
    public class ProductoXordenService : IProductoXordenService
    {
        private readonly IProductosXordenRepository _repository;
        private readonly IMapper _mapper;

        public ProductoXordenService(IProductosXordenRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public void DeleteProductoXordenById(decimal idProdOrden)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductoXordenResponse> GetProductoXorden()
        {
            var productosXordens = _repository.GetProductoXorden();
            var productosXordensResponse = _mapper.Map<IEnumerable<ProductoXordenResponse>>(productosXordens);
            return productosXordensResponse;
        }

        public ProductoXordenResponse GetProductoXordenById(int Id)
        {
            var prodXorden = _repository.GetProductoXordenById(Id);
            var prodXordenResponse = _mapper.Map<ProductoXordenResponse>(prodXorden);
            return prodXordenResponse;
        }

        public object? GetProductoXordenById(decimal idProdOrden)
        {
            throw new NotImplementedException();
        }

        public void InsertProductoXorden(CreateProductoXordenRequest request)
        {
            var prodXorden = _mapper.Map<ProductosXorden>(request);
            _repository.InsertProductoXorden(prodXorden);
        }

        public void UpdateProductoXordenById(UpdateProductoXordenRequest request)
        {
            var prodXorden = _mapper.Map<ProductosXorden>(request);
            _repository.UpdateProductoXordenById(prodXorden);
        }
    }

}
