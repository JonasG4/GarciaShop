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
    public class EliminarDetallePedidoModel : PageModel
    {
        private readonly IDetallePedidoRepository _detallePedidoRepository;

        public EliminarDetallePedidoModel(IDetallePedidoRepository detallePedidoRepository)
        {
            _detallePedidoRepository = detallePedidoRepository;
        }
        [BindProperty]
        public IEnumerable<DetallePedido> DetallePedidos { get; set; }
        public IActionResult OnGet(int Id)
        {
            var DeleteProducto = _detallePedidoRepository.GetById(Id);
            _detallePedidoRepository.Delete(DeleteProducto);

            return RedirectToPage("./DetalleProducto");
        }
    }
}
