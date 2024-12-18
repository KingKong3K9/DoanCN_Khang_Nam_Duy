﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DoanCN_Khang_Nam_Duy.Common;

namespace DoanCN_Khang_Nam_Duy.Models.ViewModels.UngTuyen
{
    public class UngTuyenVm
    {
        public int MaUngVien { get; set; }

        public int MaTTD { get; set; }
        public string TenUngVien { get; set; }

        public string TenCongViec { get; set; }
        public string TieuDeTTD => StringHelper.ToUnsignString(TenCongViec).ToLower();

        [Required(ErrorMessage = "Bạn chưa chọn hồ sơ xin việc")]
        public string LinkHoSo { get; set; }

        public string NgayUngTuyen { get; set; }

        public string TrangThai { get; set; }

        public int TrangThaiTimViec { get; set; }
    }
}