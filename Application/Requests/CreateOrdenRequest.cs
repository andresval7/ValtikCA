using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValtikCA.Application.Requests
{
    public class CreateOrdenRequest
    {
        public decimal IdCliente { get; set; }
        public int Cantidad { get; set; }
        public string? DireccionEnvio { get; set; }
        public string FechaOrden { get; set; } = null!;
        public string EstadoOrden { get; set; } = null!;
    }
}
