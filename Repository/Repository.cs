using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> SelectAll() => _dbSet.AsEnumerable();

        public T Select(int id) => _dbSet.SingleOrDefault(x => x.Id == id);

        public void Add(T entity)
        {
            if(entity == null) throw new ArgumentException(nameof(entity));

            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if(entity == null) throw new ArgumentNullException(nameof(entity));

            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}
