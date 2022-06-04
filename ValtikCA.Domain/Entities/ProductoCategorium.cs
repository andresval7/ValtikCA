using System;
using System.Collections.Generic;

namespace ValtikCA.Infrastructure.Persistence
{
    public partial class ProductoCategorium
    {
        public int IdProdCategoria { get; set; }
        public string IdProducto { get; set; } = null!;
        public int IdCategoria { get; set; }

        public virtual TblCategorium IdCategoriaNavigation { get; set; } = null!;
        public virtual TblProducto IdProductoNavigation { get; set; } = null!;
    }
}
