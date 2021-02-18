using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GarciaShop.Data.Interfaces;
using GarciaShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GarciaShop.Web.Pages
{
    public class EditarProductoModel : PageModel
    {
        private readonly IProductoRepository _productoRepository;

        public EditarProductoModel(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        [BindProperty]
        public Producto Producto { get; set;}
        public IActionResult OnGet(int Id)
        {
            Producto = _productoRepository.GetById(Id);
            if (Producto == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost(int Id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var ProductoToUpdate = _productoRepository.GetById(Id);
            if(ProductoToUpdate == null)
            {
                return NotFound();
            }

            ProductoToUpdate.NombreProducto = Producto.NombreProducto;
            ProductoToUpdate.PrecioUnitario = Producto.PrecioUnitario;
            ProductoToUpdate.Existencias = Producto.Existencias;

            _productoRepository.Update(ProductoToUpdate);

            return RedirectToPage("./Producto");

        }
    }
}
