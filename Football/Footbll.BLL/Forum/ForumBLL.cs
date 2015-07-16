using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Footbll.Model;
using Footbll.Repository;
using Footbll.IRepository;
using Football.IBLL;

namespace Footbll.BLL
{
    public class ForumBLL : IForumBLL
    {
        private readonly IForumRepository _forumRepository;

        public ForumBLL()
        {
            _forumRepository = new ForumRepository();
        }

        /// <summary>
        /// 发布帖子
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool AddForum(Forum entity)
        {
            entity.ForumId = Guid.NewGuid();
            entity.CreateUser = "";
            entity.CreateTime = DateTime.Now;
            entity.ReplyAmount = 0;
            entity.CheckAmount = 0;

            return _forumRepository.AddEntity(entity);
        }

        /// <summary>
        /// 分页 获取帖子
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public List<Forum> GetForumlist(int pageSize, int pageIndex, out int totals)
        {
            totals = 0;
            return _forumRepository.GetForumlist(pageSize, pageIndex, out totals);
        }
    }
}
