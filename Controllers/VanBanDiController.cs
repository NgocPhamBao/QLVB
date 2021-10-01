using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLVB.Controllers
{
    public class VanBanDiController : Controller
    {
        // GET: VanBanDi
        public ActionResult DangKiVanBanDi()
        {
            return View();
        }
        public ActionResult VanBanChoPhatHanh()
        {
            return View();
        }

        // GET: VanBanDi/Details/5
    }
}
