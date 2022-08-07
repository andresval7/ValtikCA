﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValtikCA.Application.Requests
{
    public class CreateCategoriaRequest
    {
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Miniatura { get; set; }
    }
}
