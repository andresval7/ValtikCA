using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Infrastructure.Persistence;

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
