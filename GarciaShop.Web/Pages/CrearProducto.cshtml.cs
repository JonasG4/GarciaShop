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
    public class CrearProductoModel : PageModel
    {
        private readonly IProductoRepository _productoRepository;
        public CrearProductoModel(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        [BindProperty]
        public Producto Producto { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost(int Id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _productoRepository.Insert(Producto);

            return RedirectToPage("./Producto");

        }
    }
}
