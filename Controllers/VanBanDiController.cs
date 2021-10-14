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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DangKyVanBanDi()
        {
            return View();
        }
        public ActionResult VanBanChoPhatHanh()
        {
            return View();
        }
        public ActionResult PhatHanhVanBan()
        {
            return View();
        }
        public ActionResult DanhSachDangKyVanBanDi()
        {
            return View();
        }
        public ActionResult ThongKe()
        {
            return View();
        }
    }
}