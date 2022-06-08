using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Infrastructure.Persistence;


namespace ValtikCA.Domain.Interfaces
{
    public interface IProductoCategoriaRepository
    {
        public IEnumerable<ProductoCategoria> GetProductoCategoria();
        public ProductoCategoria GetProductoCategoriaById(int Id);
        public void InsertProductoCategoria(ProductoCategoria idProdcategoria);
        public void UpdateProductoCategoriaById(ProductoCategoria idProdcategoria);
        public void DeleteProductoCategoriaById(ProductoCategoria idProdcategoria);
    }
}
