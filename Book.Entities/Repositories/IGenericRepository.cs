using System.Linq.Expressions;


namespace Book_Store.Repositories
{
    public interface IGenericRepository<T> where T : class
    {

        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null ,string? includeword = null);

        T GetFirstOrdeFault(Expression<Func<T, bool>> predicate= null, string? includeword = null);

        void Add(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

    }
}
