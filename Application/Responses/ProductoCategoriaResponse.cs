using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValtikCA.Application.Responses
{
    public class ProductoCategoriaResponse
    {
        public int IdProdCategoria { get; set; }
        public string IdProducto { get; set; } = null!;
        public int IdCategoria { get; set; }
    }
}
