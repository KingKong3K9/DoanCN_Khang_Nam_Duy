using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoanCN_Khang_Nam_Duy.Models.ViewModels.UngVien
{
    public class UngVienVm
    {
        public int MaUngVien { get; set; }

        [Required(ErrorMessage = "Bạn phải tên ứng viên")]
        public string TenUngVien { get; set; }

        public string SoDienThoai { get; set; }

        public string GioiTinh { get; set; }

        public string NgaySinh { get; set; }

        public string DiaChi { get; set; }
    }
}