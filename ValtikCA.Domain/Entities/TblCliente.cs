using System;
using System.Collections.Generic;

namespace ValtikCA.Infrastructure.Persistence
{
    public partial class TblCliente
    {
        public TblCliente()
        {
            TblOrdenes = new HashSet<TblOrdene>();
        }

        public decimal IdCliente { get; set; }
        public string Nombre1 { get; set; } = null!;
        public string Nombre2 { get; set; } = null!;
        public string Apellido1 { get; set; } = null!;
        public string Apellido2 { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password1 { get; set; } = null!;
        public string? Direccion { get; set; }
        public decimal? Telefono { get; set; }
        public string? Ciudad { get; set; }
        public string Provincia { get; set; } = null!;
        public decimal? CodigoPostal { get; set; }

        public virtual ICollection<TblOrdene> TblOrdenes { get; set; }
    }
}
