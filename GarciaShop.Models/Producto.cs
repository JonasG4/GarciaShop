using System;
using System.Collections.Generic;
using System.Text;

namespace GarciaShop.Models
{
    public class Producto : EntityBase
    {
        public String Codigo { get; set; }
        public String NombreProducto { get; set; }
        public Decimal PrecioUnitario { get; set; }
        public int Existencias { get; set; }

    }
}
