using System;
using System.Collections.Generic;

namespace ValtikCA.Domain.Entities
{
    public partial class Orden
    {
        public Orden()
        {
            ProductosXordens = new HashSet<ProductosXorden>();
        }

        public decimal IdOrden { get; set; }
        public decimal IdCliente { get; set; }
        public int Cantidad { get; set; }
        public string? DireccionEnvio { get; set; }
        public string FechaOrden { get; set; } = null!;
        public string EstadoOrden { get; set; } = null!;

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<ProductosXorden> ProductosXordens { get; set; }
    }
}
