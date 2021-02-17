using GarciaShop.Data.Interfaces;
using GarciaShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarciaShop.Data.Repository
{
    class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        private readonly ApplicationDbContext _db;
        public PedidoRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
