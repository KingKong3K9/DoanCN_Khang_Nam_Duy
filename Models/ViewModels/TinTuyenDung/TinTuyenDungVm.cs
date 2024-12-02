using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DoanCN_Khang_Nam_Duy.Common;

namespace DoanCN_Khang_Nam_Duy.Models.ViewModels.TinTuyenDung
{
    public class TinTuyenDungVm
    {
        public int MaTTD { get; set; }

        public string TenNTD { get; set; }

        public string TenCongViec { get; set; }
        public string TieuDeTTD => StringHelper.ToUnsignString(TenCongViec).ToLower();

        public int? SoLuong { get; set; }

        public string NgayDang { get; set; }

        public string HanNop { get; set; }

        public int? LuotXem { get; set; }

        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
    }
}