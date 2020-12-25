using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryModel
{
    public interface IGenericRepository <T> : IDisposable where T : class
    {
        IEnumerable<T> GetAllRecords();
        IEnumerable<T> FindRecord(Expression<Func<T,bool>> predicate);
        T GetRecordById(int objId);
        void AddRecord(T obj);
        void DeleteRecord(T obj);

        void UpdateRecord(T obj);

        void Save();




    }
}
 