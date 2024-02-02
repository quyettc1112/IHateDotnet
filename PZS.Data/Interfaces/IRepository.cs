using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PZS.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        Task<bool> Add(T entity);
        Task<bool> Remove(Guid id);
        Task<bool> Upsert(T entity);


        IList<T> GetAll_V2();
        T Get(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
