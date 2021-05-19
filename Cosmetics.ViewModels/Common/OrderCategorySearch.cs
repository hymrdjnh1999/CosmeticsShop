﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Common
{
    public class OrderCategorySearch
    {
        public static List<SelectListItem> Categories { get; set; } = new List<SelectListItem>() {
                new SelectListItem() { Value = "phone", Text = "Số điện thoại" },
                new SelectListItem() { Value = "id", Text = "Mã đơn hàng"},
                new SelectListItem() { Value = "shipname", Text = "Người nhận"},

            };
    }
}
