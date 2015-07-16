using Footbll.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Footbll.IRepository
{
    public interface IForumRepository
    {
        /// <summary>
        /// 发布帖子
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool AddEntity(Forum entity);

        /// <summary>
        /// 分页 获取帖子
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        List<Forum> GetForumlist(int pageSize, int pageIndex, out int totals);
    }
}
