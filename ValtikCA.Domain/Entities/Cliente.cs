using System;
using System.Collections.Generic;

namespace ValtikCA.Domain.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            TblOrdenes = new HashSet<Orden>();
        }

        public decimal IdCliente { get; set; }
        public string Nombre1 { get; set; } = null!;
        public string? Nombre2 { get; set; }
        public string Apellido1 { get; set; } = null!;
        public string? Apellido2 { get; set; }
        public string Email { get; set; } = null!;
        public string Password1 { get; set; } = null!;
        public string? Direccion { get; set; }
        public decimal? Telefono { get; set; }
        public string? Ciudad { get; set; }
        public string Provincia { get; set; } = null!;
        public decimal? CodigoPostal { get; set; }
        public int? esEmpleado { get; set; }


        public virtual ICollection<Orden> TblOrdenes { get; set; }
    }
}
