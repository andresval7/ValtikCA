using ValtikCA.Domain.Entities;

namespace ValtikCA.Domain.Interfaces
{
    public interface IProductosXordenRepository
    {
        public IEnumerable<ProductosXorden> GetProductoXorden();
        public ProductosXorden GetProductoXordenById(decimal Id);
        public void InsertProductoXorden(ProductosXorden prodXOrden);
        public void UpdateProductoXordenById(ProductosXorden prodXOrden);
        public void DeleteProductoXordenById(ProductosXorden prodXOrden);
        
    }
}
