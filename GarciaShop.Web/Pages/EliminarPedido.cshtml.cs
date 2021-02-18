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
    public class EliminarPedidoModel : PageModel
    {
        private readonly IPedidoRepository _pedidoRepository;

        public EliminarPedidoModel(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        [BindProperty]
        public IEnumerable<Pedido> Pedidos { get; set; }
        public IActionResult OnGet(int Id)
        {
            var DeleteProducto = _pedidoRepository.GetById(Id);
            _pedidoRepository.Delete(DeleteProducto);
            return RedirectToPage("./Pedido");
        }
     
    }
}
