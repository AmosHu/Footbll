using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Footbll.BLL;
using Football.IBLL;
using Footbll.Web.Models;
using Footbll.Model;

namespace Footbll.Web.Controllers
{
    /// <summary>
    /// 论坛 发帖
    /// </summary>
    public class ForumController : Controller
    {
        private MessageModel msg = null;
        private readonly IForumBLL _forumBLL;

        public ForumController()
        {
            _forumBLL = new ForumBLL();
        }

        public ActionResult Index()
        {
            return View();
        }


        #region 发帖

        public ActionResult PostForum()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public JsonResult PostForum(Forum model)
        {
            bool isSuccess = false;
            try
            {
                isSuccess = _forumBLL.AddForum(model);
                msg = isSuccess == true ? new MessageModel() { MessageType = MessageType.Success, Messages = "发布帖子成功！" } : new MessageModel() { MessageType = MessageType.Fail, Messages = "发布帖子失败！" };
            }
            catch (Exception)
            {
                msg = new MessageModel() { Messages = "发布帖子发生异常，请联系管理员！", MessageType = MessageType.Fail };
            }

            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}
