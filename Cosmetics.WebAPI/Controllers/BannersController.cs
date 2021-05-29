using Cosmetics.ViewModels.Catalogs.Banners;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Application.Catalog.Banners;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.WebAPI.Controllers
{
    public class BannersController : Controller
    {
        private readonly IBannerService _bannerService;

        public BannersController(
            IBannerService bannerService)
        {
            _bannerService = bannerService;
        }


    }
}
