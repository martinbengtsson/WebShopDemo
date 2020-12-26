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
    public class OrderRepository : GenericRepository<Orders>, IOrderRepository
    {
        private readonly DBContext context;

        public OrderRepository(DBContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<Orders> GetOrdersAndProducts()
        {

           var ctex = context.Orders.Include(c => c.product);


            return ctex.ToList();
        }


        //public IEnumerable<Orders> GetOrdersByUser()
        //{

        //}
    }
}
