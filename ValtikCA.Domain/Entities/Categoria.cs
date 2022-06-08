using System;
using System.Collections.Generic;

namespace ValtikCA.Infrastructure.Persistence
{
    public partial class Categoria
    {
        public Categoria()
        {
            ProductoCategoria = new HashSet<ProductoCategoria>();
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Miniatura { get; set; }

        public virtual ICollection<ProductoCategoria> ProductoCategoria { get; set; }
    }
}
