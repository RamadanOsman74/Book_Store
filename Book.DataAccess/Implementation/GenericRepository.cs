using Book.DataAccess.Data;
using Book_Store.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Book.DataAccess.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly BookDbContext _dbcontext;
        private DbSet<T> _dbSet;
        public GenericRepository(BookDbContext dbcontext)
        {
            _dbcontext = dbcontext;
            _dbSet = _dbcontext.Set<T>(); 
        }


        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }


        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate, string? includeword = null)
        {
            IQueryable<T> query = _dbSet;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeword != null)
            {
                foreach (var item in includeword.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
                return query.ToList();
        
        }

        public T GetFirstOrdeFault(Expression<Func<T, bool>>? predicate = null, string? includeword = null)
        {
            IQueryable<T> query = _dbSet;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (includeword != null)
            {
                foreach (var item in includeword.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity); 
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

     
    }
}
