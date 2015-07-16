using Football.IBLL;
using Footbll.BLL;
using Footbll.Model;
using Footbll.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Footbll.Web.Controllers
{
    public class HomeController : Controller
    {

        private MessageModel msg = null;
        private readonly IForumBLL _forumBLL;

        public HomeController()
        {
            _forumBLL = new ForumBLL();
        }

        #region 获取帖子

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetForumlist(int pageIndex)
        {
            int pageSize = 1;
            //得到数据的条数
            int rowCount = 0;
            List<Forum> list = _forumBLL.GetForumlist(pageSize, pageIndex, out rowCount);


            //通过计算，得到分页应该需要分几页，其中不满一页的数据按一页计算
            if (rowCount % pageSize != 0)
            {
                rowCount = rowCount / pageSize + 1;
            }
            else
            {
                rowCount = rowCount / pageSize;
            }

            //转成Json格式
            var strResult = "{\"pageCount\":" + rowCount + ",\"CurrentPage\":" + pageIndex + ",\"list\":" + JsonConvert.SerializeObject(list) + "}";

            return Json(strResult, JsonRequestBehavior.AllowGet);
        }

        #endregion

    }
}
