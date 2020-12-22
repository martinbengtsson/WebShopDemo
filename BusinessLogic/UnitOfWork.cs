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
        public ProductRepository prodRepository { get; private set; }
      
        public UnitOfWork(DBContext context)
        {
            this._context = context;
            this.prodRepository = new ProductRepository(this._context);
        }

 

        public void SaveChanges()
        {
           
        }
    }
}
