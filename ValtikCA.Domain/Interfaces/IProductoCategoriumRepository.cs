using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Infrastructure.Persistence;


namespace ValtikCA.Domain.Interfaces
{
    public interface IProductoCategoriumRepository
    {
        public IEnumerable<ProductoCategorium> GetProductoCategorium();
        public ProductoCategorium GetProductoCategoriumById(string Id);
        public void InsertProductoCategorium(ProductoCategorium idProdcategoria);
        public void UpdateProductoCategoriumById(ProductoCategorium idProdcategoria);
        public void DeleteProductoCategoriumById(ProductoCategorium idProdcategoria);
    }
}
