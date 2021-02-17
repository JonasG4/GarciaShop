using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GarciaShop.Models
{
    public class Pedido : EntityBase
    {
        [Required(ErrorMessage = "Esta campo no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El numero de caracteres debe ser mayor a 3")]
        [MaxLength(50)]
        [Display(Name = "Nombre del Cliente")]
        public string NombreCliente { get; set; }
        [Required(ErrorMessage = "Esta campo no puede estar vacio")]
        [Display(Name = "Fecha del Pedido")]
        public DateTime Fecha{ get; set; } 
    }
}
