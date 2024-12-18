﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DoanCN_Khang_Nam_Duy.Models.DAL;
using DoanCN_Khang_Nam_Duy.Models.ViewModels.Common;

namespace DoanCN_Khang_Nam_Duy.Controllers
{
    public class EmployerController : BaseController
    {
        private readonly NhaTuyenDungDAL nhatuyendungDao;
        public EmployerController()
        {
            nhatuyendungDao = new NhaTuyenDungDAL();
        }

        // GET: Employer
        public async Task<ActionResult> Index(int id)
        {
            var employer = await nhatuyendungDao.GetByIdClient(id);
            return View(employer);
        }

        public ActionResult GetPaging(int idNTD, int pageIndex = 1, int pageSize = 5)
        {
            var request = new GetListPaging()
            {
                keyWord = null,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var danhSach = new TinTuyenDungDAL()
                .LayDanhSachTheoNhaTuyenDung(request, idNTD);
            int totalRecord = danhSach.TotalRecord;
            int toalPage = (int)Math.Ceiling((double)totalRecord / pageSize);
            return Json(new { data = danhSach.Items, pageCurrent = pageIndex, toalPage = toalPage, totalRecord = totalRecord }
                , JsonRequestBehavior.AllowGet);
        }
    }
}