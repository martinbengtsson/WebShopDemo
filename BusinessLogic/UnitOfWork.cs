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
        public ProductRepository productRepository { get; private set; }
        public OrderRepository OrderReposity  { get; private set; }

        public UnitOfWork(DBContext context)
        {
            this._context = context;
            this.productRepository = new ProductRepository(this._context);
            this.OrderReposity = new OrderRepository(this._context);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
