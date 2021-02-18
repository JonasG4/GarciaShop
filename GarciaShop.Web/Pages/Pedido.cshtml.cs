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
    public class PedidoModel : PageModel
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoModel(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        [BindProperty]
        public IEnumerable<Pedido> Pedidos { get; set; }
        public IActionResult OnGet()
        {
        Pedidos = _pedidoRepository.List();
            return Page();
        }
    }
}
