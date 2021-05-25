﻿using CosmeticsShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Banners
{
    class BannerViewModel
    {
        public int Id { get; set; }
        [DisplayName("Ảnh")]
        public string ImagePath { get; set; }
        [DisplayName("Mô Tả")]
        public string Description { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateCreated { get; set; }
        public int SortOrder { get; set; }
        public long FileSize { get; set; }
        public Status Status { get; set; }

    }
}

namespace Cosmetics.ViewModels
{
    public class BannerCreateRequest
    {
    }
}