using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLVB.Controllers
{
    public class VanBanDenController : Controller
    {
        // GET: VanBanDen
        public ActionResult NhapMoi()
        {
            return View();
        }
        public ActionResult DanhSachDangKy()
        {
            return View();
        }
    }
}