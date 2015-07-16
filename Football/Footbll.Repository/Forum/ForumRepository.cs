using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using Footbll.Model;
using Footbll.IRepository;

namespace Footbll.Repository
{
    public class ForumRepository : IForumRepository
    {
        FootballEntities dbEntities;

        public ForumRepository()
        {
            dbEntities = new FootballEntities();
        }

        /// <summary>
        /// 发布帖子
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool AddEntity(Forum entity)
        {
            dbEntities.Entry<Forum>(entity).State = EntityState.Added;
            int result = dbEntities.SaveChanges();
            return result > 0;
        }

        /// <summary>
        /// 分页 获取帖子
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public List<Forum> GetForumlist(int pageSize, int pageIndex, out int totals)
        {
            totals = dbEntities.Forum.Count();

            return dbEntities.Set<Forum>().OrderBy(f => f.CreateTime).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
