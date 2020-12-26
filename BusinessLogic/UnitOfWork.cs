using DAL.DBContext;
using ModelsLayer;
using RepositoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class UnitOfWork : IUnitOfWork
    {
        private DBContext _context;
        //  public ProductRepository productRepository { get; private set; }
        //public OrderRepository OrderReposity  { get; private set; }
        public IGenericRepository<Product> productRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public OrderProductRepository OrderProduct { get; set; }

        public UnitOfWork(DBContext context)
        {
            this._context = context;

            this.productRepository = new GenericRepository<Product>(this._context);
            this.OrderRepository = new OrderRepository(this._context);
            this.OrderProduct = new OrderProductRepository(this._context);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
