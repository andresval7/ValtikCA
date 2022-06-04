﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValtikCA.Application.Requests
{
    public class ReadProductoRequest
    {
        public string IdProducto { get; set; } = null!;
        public string Sku { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public int Categoria { get; set; }
        public int Stock { get; set; }
    }
}
