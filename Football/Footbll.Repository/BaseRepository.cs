
using Footbll.IRepository;
using Footbll.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footbll.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class,new()
    {
        FootballEntities dbEntities;

        public BaseRepository()
        {
            dbEntities = new FootballEntities();
        }

        /// <summary>
        /// Create Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool AddEntity(T entity)
        {
            dbEntities.Entry<T>(entity).State = EntityState.Added;
            int result = dbEntities.SaveChanges();

            return result > 0;
        }

        /// <summary>
        /// Update Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool UpdateEntity(T entity)
        {
            dbEntities.Set<T>().Attach(entity);
            dbEntities.Entry<T>(entity).State = EntityState.Modified;

            return dbEntities.SaveChanges() > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool DeleteEntity(T entity)
        {
            dbEntities.Set<T>().Attach(entity);
            dbEntities.Entry<T>(entity).State = EntityState.Deleted;

            return dbEntities.SaveChanges() > 0;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public IQueryable<T> LoadEntities(Func<T, bool> whereLambda)
        {
            return dbEntities.Set<T>().Where<T>(whereLambda).AsQueryable();
        }

    }
}
