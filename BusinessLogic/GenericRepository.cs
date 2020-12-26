using DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using RepositoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace BusinessLogic
{
    public class GenericRepository<T> : IGenericRepository<T>, IDisposable where T : class
    {
        private readonly DBContext _context;
        private readonly DbSet<T> _DbSet;

        public GenericRepository(DBContext context)
        {
            this._context = context;
            this._DbSet = this._context.Set<T>();
        }

       
        virtual public IEnumerable<T> GetAllRecords()
        {
            //return _context.Set<T>();

            return _DbSet.ToList<T>();
        }

        public IEnumerable<T> FindRecord(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T GetRecordById(int objId)
        {
          return  _DbSet.Find(objId);
        }

        public void AddRecord(T obj)
        {
            _DbSet.Add(obj);
        }

        public void DeleteRecord(T obj)
        {
            _DbSet.Remove(obj);
        }

        public void UpdateRecord(T obj)
        {
            _DbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
