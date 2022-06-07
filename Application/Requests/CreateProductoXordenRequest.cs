using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValtikCA.Application.Requests
{
    public class CreateProductoXordenRequest
    {
        public decimal IdProdOrden { get; set; }
        public decimal IdOrden { get; set; }
        public string IdProducto { get; set; } = null!;
        public string Sku { get; set; } = null!;
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
    }
}
