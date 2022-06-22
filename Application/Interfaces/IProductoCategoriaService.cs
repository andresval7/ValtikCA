using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;

namespace ValtikCA.Application.Interfaces
{
    public interface IProductoCategoriaService
    {
        ProductoCategoriaResponse GetProductoCategoriaById(int Id);

        IEnumerable<ProductoCategoriaResponse> GetProductoCategoria();

        void InsertProductoCategoria(CreateProductoCategoriaRequest idProdcategoria);


        void DeleteProductoCategoria(int Id);

        void UpdateProductoCategoria(UpdateProductoCategoria request);
    }
}
