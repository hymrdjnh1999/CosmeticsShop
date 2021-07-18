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
        private readonly IConfiguration _config;
        public BannerController(IBannerApiClient bannerApiClient,
            IConfiguration config)
        {
            _config = config;
            _bannerApiClient = bannerApiClient;
        }
        public async Task<IActionResult> Index(string keyword = "", int pageSize = 5, int pageIndex = 1)
        {
            var paginateRequest = new PaginateRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _bannerApiClient.GetAllPaging(paginateRequest);
            ViewBag.Keyword = paginateRequest.Keyword;


            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }

        [HttpGet("Banner/Create")]
        public  IActionResult Create()
        {
           
            return View();
        }

        [HttpPost("Banner/Create")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] BannerCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var banner = await _bannerApiClient.Create(request);

            if (banner)
            {
                TempData["result"] = "Thêm ảnh bìa thành công!";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Thêm ảnh bìa thất bại!");
            return View(request);
        }

        

        [HttpGet("banner/{id}")]
        public  async Task<IActionResult> Update(int id)
        {
            if (!ModelState.IsValid || id ==0)
            {
                return RedirectToAction("Error", "Home");
            }
            var banner = await _bannerApiClient.GetById(id);
            if (banner == null)
            {
                return RedirectToAction("Error", "Home");
            }
            var model = new BannerUpdateRequest() { Id = banner.Id, Name = banner.Name , Description = banner.Description, IsOutstanding = banner.IsOutstanding ,ImagePath = banner.ImagePath};

            return View(model); 
        }


        [HttpPost("banner/{id}")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Update([FromForm] BannerUpdateRequest request)
        {
           
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Cập nhập thông tin ảnh bìa không thành công!");
                return View(request);
            }

            var result = await _bannerApiClient.Update(request);
            if (result)
            {
                TempData["result"] = "Cập nhật thông tin ảnh bìa thành công!";
                return RedirectToAction("Index");

            }
            ModelState.AddModelError("", "Cập nhật thông tin ảnh bìa không thành công!");
            return View(request);

        }
        [HttpPost]
        public async Task Delete(int id)
        {
            if (id > 0)
            {
                var result = await _bannerApiClient.Delete(id);
                if (result)
                    TempData["result"] = "Xóa thành công!";
                RedirectToAction("Index");
            }

            RedirectToAction("Error", "Home");
        }

    }







}

