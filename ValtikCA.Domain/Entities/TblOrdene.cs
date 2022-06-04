using System;
using System.Collections.Generic;

namespace ValtikCA.Infrastructure.Persistence
{
    public partial class TblOrdene
    {
        public TblOrdene()
        {
            ProductosXordens = new HashSet<ProductosXorden>();
        }

        public decimal IdOrden { get; set; }
        public decimal IdCliente { get; set; }
        public int Cantidad { get; set; }
        public string? DireccionEnvio { get; set; }
        public string FechaOrden { get; set; } = null!;
        public string EstadoOrden { get; set; } = null!;

        public virtual TblCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<ProductosXorden> ProductosXordens { get; set; }
    }
}
