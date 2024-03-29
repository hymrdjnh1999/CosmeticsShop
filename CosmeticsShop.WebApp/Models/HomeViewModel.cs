﻿using Cosmetics.ViewModels.Catalogs.Banners;
using Cosmetics.ViewModels.Catalogs.Categories;
using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmeticsShop.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideViewModel> Slides { get; set; }
        public List<BannerViewModel> Banners { get; set; }
        public List<HomeCategoryViewModel> Categories { get; set; }
    }
}
