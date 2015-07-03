using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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

        #region 用户登录

        public Sys_User LoginByUserInfo(string strUserName, string strPwd)
        {
            Sys_User user = _userrepository.LoadEntities(u => u.UserName == strUserName && u.Password == strPwd).FirstOrDefault();

            if (user == null)
                user = _userrepository.LoadEntities(u => u.Email == strUserName && u.Password == strPwd).FirstOrDefault();

            return user;
        }

        #endregion

    }
}