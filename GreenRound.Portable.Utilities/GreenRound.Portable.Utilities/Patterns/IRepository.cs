using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenRound.Portable.Utilities.Patterns
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        IEnumerable<T> GetEntities();
    }
}
