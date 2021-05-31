using Cosmetics.ViewModels.Catalogs.Banners;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Api_Intergration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.AdminApp.Controllers
{
    public class BannerController : BaseController
    {

        private readonly IBannerApiClient _bannerApiClient;

        public BannerController(IBannerApiClient bannerApiClient)
        {
            _bannerApiClient = bannerApiClient;
        }
        public async Task<IActionResult> Index(string keyword = "", int pageSize = 10, int pageIndex = 1)
        {
            var paginateRequest = new PaginateRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };

            var banners = await _bannerApiClient.GetAllPaging(paginateRequest);
            ViewBag.Keyword = paginateRequest.Keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }

            return View(banners);
        }

        [HttpGet("banner/create")]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost("banner/create")]
        public async Task<IActionResult> Create(BannerCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _bannerApiClient.Create(request);

            if (result )
            {
                TempData["result"] = "Tạo ảnh bìa thành công!";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Tạo ảnh bìa thất bại!");
            return View(request);
        }

        [HttpGet("banner/{id}")]
        public async Task<IActionResult> Edit(int id)
        {

            var banner = await _bannerApiClient.GetById(id);
            if (banner == null)
            {
                return RedirectToAction("Error", "Home");
            }
            var model = new BannerUpdateRequest() {
                Id = id, 
                Name = banner.Name,
                Description = banner.Description,
                ImagePath = banner.ImagePath
            };
            return View(model);
        }

        [HttpPost("banner/{id}")]
        public async Task<IActionResult> Edit(BannerUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _bannerApiClient.Edit(request);

            if (result)
            {
                TempData["result"] = "Cập nhật ảnh bìa thành công";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Cập nhật ảnh bìa thất bại!");
            return View(request);
        }
        [HttpDelete]
        public async Task Delete(int id)
        {

            var category = await _bannerApiClient.GetById(id);
            if (category == null)
            {

                RedirectToAction("Error", "Home");
            }
            else
            {
                var result = await _bannerApiClient.Delete(id);

                if (result)
                {
                    TempData["result"] = "Xóa ảnh bìa thành công";
                    RedirectToAction("Index");
                }
                else
                {

                    TempData["error"] = "Xóa ảnh bìa thất bại";
                    RedirectToAction("Index");
                }

            }
        }

    }







}
}
