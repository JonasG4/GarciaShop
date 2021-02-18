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
    public class DeleteProductoModel : PageModel
    {
        private readonly IProductoRepository _productoRepository;

        public DeleteProductoModel(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        [BindProperty]
        public IEnumerable<Producto> Productos { get; set; }
        public IActionResult OnGet(int Id)
        {
            var DeleteProducto = _productoRepository.GetById(Id);
            _productoRepository.Delete(DeleteProducto);

            return RedirectToPage("./Producto");
        }
    }
}
