using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Footbll.IRepository
{
    public interface IBaseRepository<T> where T : class,new()
    {
        IQueryable<T> LoadEntities(Func<T, bool> whereLambda);

        bool UpdateEntity(T entity);

        bool AddEntity(T entity);

        bool DeleteEntity(T entity);
    }
}
