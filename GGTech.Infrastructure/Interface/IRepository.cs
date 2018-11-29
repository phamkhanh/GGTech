using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GGTech.Infrastructure.Interface
{
    public interface IRepository<T, K> where T : class
    {
        T SelectById(K id, params Expression<Func<T, object>>[] includeProperties);

        T SelectSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> SelectAll(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> SelectAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(K id);

        void DeleteMultiple(List<T> entities);
    }
}