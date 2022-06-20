using System;
using System.Collections.Generic;
using ValtikCA.Domain.Entities;

namespace ValtikCA.Domain.Entities
{
    public partial class ProductoCategoria
    {
        public int IdProdCategoria { get; set; }
        public string IdProducto { get; set; } = null!;
        public int IdCategoria { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; } = null!;
        public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
