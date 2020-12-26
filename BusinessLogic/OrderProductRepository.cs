using DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using RepositoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class OrderProductRepository : GenericRepository<OrderProduct>, IOrderProductRepository
    {
        private readonly DBContext context;

        public OrderProductRepository(DBContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<OrderProduct> GetOrdersAndProducts()
        {
            var ctex = context.OrderProduct
                .Include(c => c.order)
                .Include(b => b.product);
             return ctex.ToList();
        }
    }
}
