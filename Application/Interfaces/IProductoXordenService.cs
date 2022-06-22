using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.Application.Interfaces
{
    public interface IProductoXordenService
    {
        ProductoXordenResponse GetProductoXordenById(decimal Id);

        IEnumerable<ProductoXordenResponse> GetProductoXorden();

        void InsertProductoXorden(CreateProductoXordenRequest prodXOrden);

        void UpdateProductoXordenById(UpdateProductoXordenRequest prodXOrden);

        void DeleteProductoXordenById(DeleteProductoXordenRequest prodXOrden);
        
    }
}
