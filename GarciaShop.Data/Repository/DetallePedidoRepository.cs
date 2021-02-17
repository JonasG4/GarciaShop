using GarciaShop.Data.Interfaces;
using GarciaShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarciaShop.Data.Repository
{
    class DetallePedidoRepository : Repository<DetallePedido>, IDetallePedidoRepository
    {
        private readonly ApplicationDbContext _db;
        public DetallePedidoRepository(ApplicationDbContext db) : base(db)
        {
                
        }
    }
}
