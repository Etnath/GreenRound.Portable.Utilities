using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace GreenRound.Portable.Utilities.DAL
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }
        
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T FindById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
