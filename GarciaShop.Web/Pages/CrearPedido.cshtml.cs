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
    public class CrearPedidoModel : PageModel
    {
        private readonly IPedidoRepository _pedidoRepository;
        public CrearPedidoModel(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        [BindProperty]
        public Pedido Pedido { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost(int Id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _pedidoRepository.Insert(Pedido);

            return RedirectToPage("./Producto");

        }
    }
}
