using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenRound.Portable.Utilities.Patterns
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetEntities()
        {
            throw new NotImplementedException();
        }
    }
}
