using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GarciaShop.Models
{
    public class Producto : EntityBase
    {
        [Required(ErrorMessage = "Esta campo no puede estar vacio")]
        [MinLength(3, ErrorMessage = "El numero de caracteres debe ser mayor a 3")]
        [MaxLength(50)]
        [Display(Name = "Nombre del Producto") ]
        public string NombreProducto { get; set; }
        [Required(ErrorMessage = "Esta campo no puede estar vacio")]
        [Display(Name = "Precio por Unidad")]
        public decimal PrecioUnitario { get; set; }
        [Required(ErrorMessage = "Esta campo no puede estar vacio")]
        [Display(Name = "Cantidad de Existencias")]
        public int Existencias { get; set; }

    }
}
