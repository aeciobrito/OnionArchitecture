using Domain.Models.Interfaces;

namespace Repository.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        IEnumerable<T> SelectAll();
        T Select(int id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity); 
    }
}
