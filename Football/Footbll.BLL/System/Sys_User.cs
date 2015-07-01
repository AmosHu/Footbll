using System;
using System.Text;
using System.Collections.Generic;
using System.Data;

using Footbll.Model;
using Footbll.Repository;
using Footbll.IRepository;

namespace Footbll.BLL
{
    //Sys_User
    public partial class Sys_UserBLL
    {
        private readonly ISys_UserRepository _userrepository;

        public Sys_UserBLL()
        {
            _userrepository = new Sys_UserRepository();
        }

        #region 添加实体对象

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool AddEntity(Sys_User model)
        {
            return _userrepository.AddEntity(model);
        }

        #endregion

    }
}