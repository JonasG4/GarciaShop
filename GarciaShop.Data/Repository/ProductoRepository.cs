using GarciaShop.Data.Interfaces;
using GarciaShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarciaShop.Data.Repository
{
    class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductoRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
