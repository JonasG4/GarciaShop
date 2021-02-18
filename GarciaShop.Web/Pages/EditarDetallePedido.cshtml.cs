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
    public class EditarDetallePedidoModel : PageModel
    {
        private readonly IDetallePedidoRepository _detallePedidoRepository;

        public EditarDetallePedidoModel(IDetallePedidoRepository detallePedidoRepository)
        {
            _detallePedidoRepository = detallePedidoRepository;
        }
        [BindProperty]
        public DetallePedido DetallePedido { get; set; }
        public IActionResult OnGet(int Id)
        {
            DetallePedido = _detallePedidoRepository.GetById(Id);
            if (DetallePedido == null)
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

            var DetalleProductoToUpdate = _detallePedidoRepository.GetById(Id);
            if (DetalleProductoToUpdate == null)
            {
                return NotFound();
            }

            DetalleProductoToUpdate.PedidoID = DetallePedido.PedidoID;
            DetalleProductoToUpdate.ProductoID = DetallePedido.ProductoID;
            DetalleProductoToUpdate.Cantidad = DetallePedido.Cantidad;

            _detallePedidoRepository.Update(DetalleProductoToUpdate);

            return RedirectToPage("./DetallePedido");

        }
    }
}
