using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Footbll.BLL;
using Football.IBLL;

namespace Footbll.Web.Controllers
{
    /// <summary>
    /// 名人堂
    /// </summary>
    public class FamousController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


    }
}
