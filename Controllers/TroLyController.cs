using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLVB.Controllers
{
    public class TroLyController : Controller
    {
        // GET: TroLy
        public ActionResult DuThaoVanBanDi()
        {
            return View();
        }
        public ActionResult NhapMoi()
        {
            return View();
        }
    }
}