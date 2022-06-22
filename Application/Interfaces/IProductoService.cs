using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;

namespace ValtikCA.Application.Interfaces
{
    public interface IProductoService
    {
        ProductoResponse GetProductoById(string Id);

        IEnumerable<ProductoResponse> GetProducto();

        void InsertProductoById(CreateProductoRequest request);

        void UpdateProductoById(UpdateProductoRequest request);

        void DeleteProductoById(string idProducto);
    }
}
