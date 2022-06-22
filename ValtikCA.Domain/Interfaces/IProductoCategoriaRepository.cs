using ValtikCA.Domain.Entities;

namespace ValtikCA.Domain.Interfaces
{
    public interface IProductoCategoriaRepository
    {
        public IEnumerable<ProductoCategoria> GetProductoCategoria();
        public ProductoCategoria GetProductoCategoriaById(int Id);
        public void InsertProductoCategoria(ProductoCategoria idProdcategoria);
        public void UpdateProductoCategoriaById(ProductoCategoria idProdcategoria);
        public void DeleteProductoCategoriaById(int idProdcategoria);
    }
}
