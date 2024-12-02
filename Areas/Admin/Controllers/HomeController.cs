using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DoanCN_Khang_Nam_Duy.Areas.Admin.Models;  
using DoanCN_Khang_Nam_Duy.Common;
using DoanCN_Khang_Nam_Duy.Models.DAL;

namespace DoanCN_Khang_Nam_Duy.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            ViewBag.SlUngVien = new TaiKhoanDAL().SlUngVien();
            ViewBag.SlNhaTuyenDung = new TaiKhoanDAL().SlNhaTuyenDung();
            ViewBag.SlTinTuyenDung = new TinTuyenDungDAL().SlTinTuyenDung(null, true);
            ViewBag.SlBaiViet = new BaiVietDAL().SlBaiViet(null, true);
            ViewBag.TopView = new TinTuyenDungDAL().GetListTopView(5, null);
            return View();
        }

        public ActionResult Logout()
        {
            SetAlert("Đăng xuất thành công", "success");
            Session[CommonConstants.ADMIN_SESSION] = null;
            return RedirectToAction("Index","Login");
        }

        [ChildActionOnly]
        public ActionResult _SidebarMenu()
        {
            return PartialView();
        }
    }
}