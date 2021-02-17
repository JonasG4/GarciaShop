using System;
using System.Collections.Generic;
using System.Text;

namespace GarciaShop.Models
{
    public class Pedido : EntityBase
    {
        public string NombreCliente { get; set; }
        public DateTime Fecha{ get; set; } 
    }
}
