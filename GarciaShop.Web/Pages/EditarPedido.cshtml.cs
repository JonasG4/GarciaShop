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
    public class EditarPedidoModel : PageModel
    {
        private readonly IPedidoRepository _pedidoRepository;

        public EditarPedidoModel(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        [BindProperty]
        public Pedido Pedido { get; set; }
        public IActionResult OnGet(int Id)
        {
            Pedido = _pedidoRepository.GetById(Id);
            if (Pedido == null)
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

            var PedidoToUpdate = _pedidoRepository.GetById(Id);
            if (PedidoToUpdate == null)
            {
                return NotFound();
            }

            PedidoToUpdate.NombreCliente = Pedido.NombreCliente;
            PedidoToUpdate.Fecha = Pedido.Fecha;


            _pedidoRepository.Update(PedidoToUpdate);

            return RedirectToPage("./Pedido");

        }
    }
}
