using Cosmetics.ViewModels.Catalogs.Banners;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Application.Catalog.Banners;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : Controller
    {
        private readonly IBannerService _bannerServices;

        public BannersController(IBannerService bannerService)
        {
            _bannerServices = bannerService;
        }
        [HttpPost]
        [Consumes("multipart/form-data")]
        [Authorize]

        public async Task<IActionResult> Create([FromForm] BannerCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var bannerId = await _bannerServices.Create(request);
            if (bannerId == 0)
            {
                return BadRequest();
            }

            var banner = await _bannerServices.GetById(bannerId);
            banner.Id = bannerId;

            return CreatedAtAction("Create", banner);
        }

    }
}
