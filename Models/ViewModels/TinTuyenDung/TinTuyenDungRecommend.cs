using DoanCN_Khang_Nam_Duy.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoanCN_Khang_Nam_Duy.Models.ViewModels.TinTuyenDung
{
    public class TinTuyenDungRecommend
    {
        public int MaTTD { get; set; }
        public int MaNTD { get; set; }
        public string TieuDeNTD => StringHelper.ToUnsignString(TenNTD).ToLower();
        public string TieuDeTTD => StringHelper.ToUnsignString(TenCongViec).ToLower();
        public string TenNTD { get; set; }
        public string AnhDaiDien { get; set; }
        public string TenCongViec { get; set; }
        public string LoaiCV { get; set; }
        public string MucLuong { get; set; }
        public string DiaChi { get; set; }
        public string NgayDang { get; set; }
        public string HanNop { get; set; }
        public int? SoLuong { get; set; }
    }
}