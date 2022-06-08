using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Domain.Interfaces;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private DBTiendaValtikContext _context;
        public ProductoRepository(DBTiendaValtikContext context)
        {
            _context = context;
        }

        public IEnumerable<Producto> GetProducto()
        {
            return _context.TblProductos;
        }

        public Producto GetProductoById(string Id)
        {
                var productoExistente = _context.TblProductos.
                    FirstOrDefault(x => x.IdProducto.Equals(Id));

                return productoExistente;

        }

        public void InsertProductoById(Producto producto)
        {
            _context.TblProductos.Add(producto);
            _context.SaveChanges();
        }

        public void UpdateProductoById(Producto producto)
        {
            var productoExistente = _context.TblProductos
                .FirstOrDefault(x => x.IdProducto.Equals(producto.IdProducto));
            if (productoExistente != null)
            {
                productoExistente.Sku = producto.Sku;
                productoExistente.Nombre = producto.Nombre;
                productoExistente.Precio = producto.Precio;
                productoExistente.Categoria = producto.Categoria;
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.ImgMiniatura = producto.ImgMiniatura;
                productoExistente.Imagen = producto.Imagen;
                productoExistente.Stock = producto.Stock;
                _context.SaveChanges();
            }

        }

        public void DeleteProductoById(Producto producto)
        {
            var productoExistente = _context.TblProductos
                .FirstOrDefault(x => x.IdProducto.Equals(producto.IdProducto));
            if(productoExistente != null)
            {
                _context.Remove(productoExistente);
                _context.SaveChanges();
            }
                
        }
    }
}
