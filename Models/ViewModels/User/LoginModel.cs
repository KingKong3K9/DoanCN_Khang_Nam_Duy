﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoanCN_Khang_Nam_Duy.Models.ViewModels.User
{
    public class LoginModel
    {
        public string login_email { set; get; }

        public string login_password { set; get; }
    }
}