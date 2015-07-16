using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Footbll.Model;

namespace Football.IBLL
{
    public interface IForumBLL
    {
        /// <summary>
        /// 发布帖子
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool AddForum(Forum entity);

        /// <summary>
        /// 分页 获取帖子
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        List<Forum> GetForumlist(int pageSize, int pageIndex, out int totals);
    }
}
