using System;
using System.Collections.Generic;

namespace ValtikCA.Infrastructure.Persistence
{
    public partial class TblCategorium
    {
        public TblCategorium()
        {
            ProductoCategoria = new HashSet<ProductoCategorium>();
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Miniatura { get; set; }

        public virtual ICollection<ProductoCategorium> ProductoCategoria { get; set; }
    }
}
