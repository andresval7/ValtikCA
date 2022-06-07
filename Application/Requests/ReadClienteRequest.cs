using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValtikCA.Application.Requests
{
    public class ReadClienteRequest
    {
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
    }
}
