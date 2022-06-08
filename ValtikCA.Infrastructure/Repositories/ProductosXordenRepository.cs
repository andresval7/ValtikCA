using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Domain.Interfaces;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Infrastructure.Repositories
{
    public class ProductosXordenRepository : IProductosXordenRepository
    {
        private DBTiendaValtikContext _context;
        public ProductosXordenRepository(DBTiendaValtikContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductosXorden> GetProductoXorden()
        {
            return _context.ProductosXordens;
        }

        public ProductosXorden GetProductoXordenById(int Id)
        {
            var prodOrdenExistente = _context.ProductosXordens.
                FirstOrDefault(x => x.IdProdOrden == (Id));

            return prodOrdenExistente;

        }

        public void InsertProductoXorden(ProductosXorden prodXOrden)
        {
            _context.ProductosXordens.Add(prodXOrden);
            _context.SaveChanges();
        }

        public void UpdateProductoXordenById(ProductosXorden prodXOrden)
        {
            var prodOrdenExistente = _context.ProductosXordens
                .FirstOrDefault(x => x.IdProdOrden == (prodXOrden.IdProdOrden));
            if (prodOrdenExistente != null)
            {
                prodOrdenExistente.IdProdOrden = prodXOrden.IdProdOrden;
                prodOrdenExistente.IdOrden = prodXOrden.IdOrden;
                prodOrdenExistente.IdProducto = prodXOrden.IdProducto;
                prodOrdenExistente.Sku = prodXOrden.Sku;
                prodOrdenExistente.Cantidad = prodXOrden.Cantidad;
                prodOrdenExistente.Total = prodXOrden.Total;
                _context.SaveChanges();
            }

        }

        public void DeleteProductoXordenById(ProductosXorden prodXOrden)
        {
            var prodOrdenExistente = _context.ProductosXordens
                .FirstOrDefault(x => x.IdProdOrden == (prodXOrden.IdProdOrden));
            if (prodOrdenExistente != null)
            {
                _context.Remove(prodOrdenExistente);
                _context.SaveChanges();
            }


        }
    }
}
