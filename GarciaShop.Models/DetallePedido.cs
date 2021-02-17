using System;
using System.Collections.Generic;
using System.Text;

namespace GarciaShop.Models
{
    public class DetallePedido : EntityBase
    {
        public int PedidoID { get; set; }
        public Pedido pedido { get; set; }

        public int ProductoID { get; set; }
        public Producto producto { get; set; }
        public int Cantidad { get; set; }
    }
}
