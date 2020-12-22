using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryModel;
using Microsoft.EntityFrameworkCore;
using DAL.DBContext;

namespace BusinessLogic
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DBContext _context;

        public ProductRepository(DBContext context) : base (context)
        {
            this._context = context;
        }

        public IEnumerable<Product> GetTopSellingProducts()
        {
            return (from m in this._context.Product orderby m.Description descending select m);
        }
    }
}
