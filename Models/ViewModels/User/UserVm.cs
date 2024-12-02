﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoanCN_Khang_Nam_Duy.Models.ViewModels.User
{
    [Serializable]
    public class UserVm
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Quyen { get; set; }
        public string NgayTao { get; set; }
        public bool TrangThai { get; set; }
    }
}