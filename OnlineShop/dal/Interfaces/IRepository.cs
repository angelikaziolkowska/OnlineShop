using System;
using System.Linq;
using System.Linq.Expressions;

namespace ConnexusComponents.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Create(T entity);
        T Delete(T entity);
        T FirstOrDefault();
        T FirstOrDefault(Func<T, bool> func);
        IQueryable<T> GetAll();
        void Update(T entity);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
    }
}
