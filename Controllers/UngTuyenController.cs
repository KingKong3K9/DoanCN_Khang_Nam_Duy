using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoanCN_Khang_Nam_Duy.Common;
using DoanCN_Khang_Nam_Duy.Models.DAL;

namespace DoanCN_Khang_Nam_Duy.Controllers
{
    public class UngTuyenController : BaseController
    {
        private readonly UngTuyenDAL UngTuyenDAL;

        public UngTuyenController()
        {
            UngTuyenDAL = new UngTuyenDAL();
        }

        // GET: UngTuyen
        public ActionResult Index()
        {
            if (UserLogin() == null)
            {
                SetAlert("Bạn chưa đăng nhập", "warning");
                return RedirectToAction("Index", "Home");
            }
            var model = UngTuyenDAL.GetListByUser(UserLogin().Id);
            return View(model);
        }

    }
}