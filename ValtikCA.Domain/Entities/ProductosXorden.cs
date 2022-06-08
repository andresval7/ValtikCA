using System;
using System.Collections.Generic;

namespace ValtikCA.Infrastructure.Persistence
{
    public partial class ProductosXorden
    {
        public decimal IdProdOrden { get; set; }
        public decimal IdOrden { get; set; }
        public string IdProducto { get; set; } = null!;
        public string Sku { get; set; } = null!;
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public virtual Orden IdOrdenNavigation { get; set; } = null!;
        public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
