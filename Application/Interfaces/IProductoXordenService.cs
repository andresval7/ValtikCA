using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.Application.Interfaces
{
    public interface IProductoXordenService
    {
        ProductoXordenResponse GetProductoXordenById(int Id);

        IEnumerable<ProductoXordenResponse> GetProductoXorden();

        void InsertProductoXorden(CreateProductoXordenRequest prodXOrden);

        void UpdateProductoXordenById(UpdateProductoXordenRequest prodXOrden);

        void DeleteProductoXordenById(decimal idProdOrden);
        object? GetProductoXordenById(decimal idProdOrden);
    }
}
