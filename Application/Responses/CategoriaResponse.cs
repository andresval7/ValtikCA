using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValtikCA.Application.Responses
{
    public class CategoriaResponse
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Miniatura { get; set; }
    }
}
