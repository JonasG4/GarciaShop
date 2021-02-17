using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GarciaShop.Models
{
    public class DetallePedido : EntityBase
    {
        [Required(ErrorMessage = "Esta campo no puede estar vacio")]
        [Display(Name = "Codigo Pedido")]
        public int PedidoID { get; set; }
        public Pedido pedido { get; set; }

        [Required(ErrorMessage = "Esta campo no puede estar vacio")]
        [Display(Name = "Codigo Producto")]
        public int ProductoID { get; set; }
        public Producto producto { get; set; }

        [Required(ErrorMessage = "Esta campo no puede estar vacio")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }
    }
}
