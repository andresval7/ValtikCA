using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Domain.Interfaces;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Infrastructure.Repositories
{
    public class ProductoCategoriaRepository : IProductoCategoriaRepository
    {
        private DBTiendaValtikContext _context;
        public ProductoCategoriaRepository(DBTiendaValtikContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductoCategoria> GetProductoCategoria()
        {
            return _context.ProductoCategoria;
        }

        public ProductoCategoria GetProductoCategoriaById(int Id)
        {
            var idProdCategoriaExistente = _context.ProductoCategoria.
                FirstOrDefault(x => x.IdProdCategoria == Id);

            return idProdCategoriaExistente;

        }

        public void InsertProductoCategoria(ProductoCategoria idProdcategoria)
        {
            _context.ProductoCategoria.Add(idProdcategoria);
            _context.SaveChanges();
        }

        public void UpdateProductoCategoriaById(ProductoCategoria idProdcategoria)
        {
            var idProdCategoriaExistente = _context.ProductoCategorium
                .FirstOrDefault(x => x.IdProdCategoria == (idProdcategoria.IdProdCategoria));
            if (idProdCategoriaExistente != null)
            {
                idProdCategoriaExistente.IdProducto = idProdcategoria.IdProducto;
                idProdCategoriaExistente.IdProdCategoria = idProdcategoria.IdProdCategoria;
                idProdCategoriaExistente.IdCategoria = idProdcategoria.IdCategoria;
                _context.SaveChanges();
            }

        }

        public void DeleteProductoCategoriaById(ProductoCategoria idProdcategoria)
        {
            var idProdCategoriaExistente = _context.ProductoCategorium
                .FirstOrDefault(x => x.IdProdCategoria == (idProdcategoria.IdProdCategoria));
            if (idProdCategoriaExistente != null)
            {
                _context.Remove(idProdCategoriaExistente);
                _context.SaveChanges();
            }


        }
    }
}
