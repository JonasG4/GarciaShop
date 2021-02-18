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
    public class CrearDetallePedidoModel : PageModel
    {
        private readonly IDetallePedidoRepository _detallePedidoRepository;

        public CrearDetallePedidoModel(IDetallePedidoRepository detallePedidoRepository)
        {
            _detallePedidoRepository = detallePedidoRepository;
        }
        [BindProperty]
        public DetallePedido DetallePedido { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost(int Id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _detallePedidoRepository.Insert(DetallePedido);
            return RedirectToPage("./DetallePedido");

        }
    }
}
