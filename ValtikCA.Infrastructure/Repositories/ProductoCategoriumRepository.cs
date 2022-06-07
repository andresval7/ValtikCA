using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Domain.Interfaces;
using ValtikCA.Infrastructure.Persistence;

namespace ValtikCA.Infrastructure.Repositories
{
    public class ProductoCategoriumRepository : IProductoCategoriumRepository
    {
        private DBTiendaValtikContext _context;
        public ProductoCategoriumRepository(DBTiendaValtikContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductoCategorium> GetProductoCategorium()
        {
            return _context.ProductoCategorium;
        }

        public ProductoCategorium GetProductoCategoriumById(string Id)
        {
            var idProdCategoriaExistente = _context.ProductoCategorium.
                FirstOrDefault(x => x.IdProdCategoria.Equals(Id));

            return idProdCategoriaExistente;

        }

        public void InsertProductoCategorium(ProductoCategorium idProdcategoria)
        {
            _context.ProductoCategorium.Add(idProdcategoria);
            _context.SaveChanges();
        }

        public void UpdateProductoCategoriumById(ProductoCategorium idProdcategoria)
        {
            var idProdCategoriaExistente = _context.ProductoCategorium
                .FirstOrDefault(x => x.IdProdCategoria.Equals(idProdcategoria.IdProdCategoria));
            if (idProdCategoriaExistente != null)
            {
                idProdCategoriaExistente.IdProducto = idProdcategoria.IdProducto;
                idProdCategoriaExistente.IdProdCategoria = idProdcategoria.IdProdCategoria;
                idProdCategoriaExistente.IdCategoria = idProdcategoria.IdCategoria;
                _context.SaveChanges();
            }

        }

        public void DeleteProductoCategoriumById(ProductoCategorium idProdcategoria)
        {
            var idProdCategoriaExistente = _context.ProductoCategorium
                .FirstOrDefault(x => x.IdProdCategoria.Equals(idProdcategoria.IdProdCategoria));
            if (idProdCategoriaExistente != null)
            {
                _context.Remove(idProdCategoriaExistente);
                _context.SaveChanges();
            }


        }
    }
}
