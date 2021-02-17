using System;
using System.Collections.Generic;
using System.Text;

namespace GarciaShop.Models
{
    public class Producto : EntityBase
    {
        public string NombreProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Existencias { get; set; }

    }
}
