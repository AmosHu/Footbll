using Footbll.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football.IBLL
{
    public interface ISys_User
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool AddUser(Sys_User model);

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUserName"></param>
        /// <param name="strPwd"></param>
        /// <returns></returns>
        Sys_User LoginByUserInfo(string strUserName, string strPwd);
    }
}
