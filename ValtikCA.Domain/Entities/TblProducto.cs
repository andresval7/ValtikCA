﻿using System;
using System.Collections.Generic;

namespace ValtikCA.Infrastructure.Persistence
{
    public partial class TblProducto
    {
        public TblProducto()
        {
            ProductoCategoria = new HashSet<ProductoCategorium>();
            ProductosXordens = new HashSet<ProductosXorden>();
        }

        public string IdProducto { get; set; } = null!;
        public string Sku { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public int Categoria { get; set; }
        public string? Descripcion { get; set; }
        public string? ImgMiniatura { get; set; }
        public string? Imagen { get; set; }
        public int Stock { get; set; }

        public virtual ICollection<ProductoCategorium> ProductoCategoria { get; set; }
        public virtual ICollection<ProductosXorden> ProductosXordens { get; set; }
    }
}