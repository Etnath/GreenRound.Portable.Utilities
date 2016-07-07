using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenRound.Portable.Utilities.Patterns
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
