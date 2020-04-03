using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewHope.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 母版页
        /// </summary>
        /// <returns></returns>
        public ActionResult Mother()
        {
            return View();
        }



    }
}