using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Domain.Interfaces
{
    public interface IProductosXordenRepository
    {
        public IEnumerable<ProductosXorden> GetProductoXorden();
        public ProductosXorden GetProductoXordenById(int Id);
        public void InsertProductoXorden(ProductosXorden prodXOrden);
        public void UpdateProductoXordenById(ProductosXorden prodXOrden);
        public void DeleteProductoXordenById(ProductosXorden prodXOrden);

    }
}
