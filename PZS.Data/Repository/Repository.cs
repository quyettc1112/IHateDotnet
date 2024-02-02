using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using PZS.Data.Interfaces;
using PZS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZS.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly PizzaStoreContext _context;
        private readonly DbSet<T> dbSet;


        public Repository(PizzaStoreContext context, DbSet<T> dbSet)
        {
            _context = context;
            this.dbSet = this._context.Set<T>();
        }

        public Task<bool> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            this.dbSet.Remove(entity); 
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public T Get(object id)
        {
            return this.dbSet.Find(id);
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll_V2()
        {
            return this.dbSet.ToList();
        }

        public Task<T?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
           this.dbSet.Add(entity);
        }

        public Task<bool> Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            this.dbSet.Attach(entity);
            this._context.Entry(entity).State = EntityState.Modified;
        }

        public Task<bool> Upsert(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
