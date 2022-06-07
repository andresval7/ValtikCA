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
        public IEnumerable<TblProducto> GetProducto();
        public TblProducto GetProductoById(string Id);
        public void InsertProductoById(TblProducto producto);
        public void UpdateProductoById(TblProducto producto);
        public void DeleteProductoById(TblProducto producto);

    }
}
