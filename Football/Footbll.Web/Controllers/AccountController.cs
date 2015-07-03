﻿using Footbll.BLL;
using Footbll.Model;
using Footbll.Web.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Footbll.Web.Controllers
{
    /// <summary>
    /// 用户登录/注册
    /// </summary>
    public class AccountController : Controller
    {

        private MessageModel msg = null;

        private Sys_UserBLL bll = new Sys_UserBLL();

        public ActionResult Index()
        {
            return View();
        }

        #region 登录

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(string strLoginName, string strPwd)
        {
            try
            {
                Sys_User user = bll.LoginByUserInfo(strLoginName, strPwd);
                msg = user != null ? new MessageModel() { MessageType = MessageType.Success, Messages = "用户注册成功！" } : new MessageModel() { MessageType = MessageType.Fail, Messages = "用户注册失败！" };
            }
            catch (Exception)
            {
                msg = new MessageModel() { Messages = "用户注册发生异常，请联系管理员！", MessageType = MessageType.Fail };
            }

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region 注册

        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public ActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public JsonResult RegisterUser(Sys_User model)
        {
            bool isSuccess = false;
            try
            {
                model.UserId = Guid.NewGuid();
                model.RegistTime = DateTime.Now;
                isSuccess = bll.AddEntity(model);
                msg = isSuccess == true ? new MessageModel() { MessageType = MessageType.Success, Messages = "用户注册成功！" } : new MessageModel() { MessageType = MessageType.Fail, Messages = "用户注册失败！" };
            }
            catch (Exception)
            {
                msg = new MessageModel() { Messages = "用户注册发生异常，请联系管理员！", MessageType = MessageType.Fail };
            }

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        #endregion

    }
}
