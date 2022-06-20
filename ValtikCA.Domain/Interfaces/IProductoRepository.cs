using ValtikCA.Domain.Entities;

namespace ValtikCA.Domain.Interfaces
{
    public interface IProductoRepository
    {
        public IEnumerable<Producto> GetProducto();
        public Producto GetProductoById(string Id);
        public void InsertProductoById(Producto producto);
        public void UpdateProductoById(Producto producto);
        public void DeleteProductoById(Producto producto);

    }
}
