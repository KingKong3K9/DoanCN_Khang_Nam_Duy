using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoanCN_Khang_Nam_Duy.Areas.Admin.Models
{
    public class AdminLogin
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}