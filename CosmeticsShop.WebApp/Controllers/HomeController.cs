using Cosmetics.ViewModels.Catalogs.Categories;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Api_Intergration;
using CosmeticsShop.Application.Ultilities;
using CosmeticsShop.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CosmeticsShop.WebApp.Controllers
{
    public class HomeController : ClientBaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISlideApiClient _slideApiClient;
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;
        private readonly IBannerApiClient _bannerApiClient;
        public HomeController(
            ILogger<HomeController> logger,
            ISlideApiClient slideApiClient,
            IProductApiClient productApiClient,
            ICategoryApiClient categoryApiClient, IBannerApiClient bannerApiClient, IClientApi clientApi) : base(clientApi)
        {
            _logger = logger;
            _slideApiClient = slideApiClient;
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
            _bannerApiClient = bannerApiClient;
        }
        
        public async Task<IActionResult> Index()
        {
            var clientId = User.Claims.ToList().Where(x => x.Type == "Id").FirstOrDefault();
            var logout = HttpContext.Session.GetString("Token") == null && clientId != null;
            if (logout)
                return RedirectToAction("Logout", "User");
            await CreateUserViewBag();
            /*            var slides = await _slideApiClient.GetAll();*/
            var banners = await _bannerApiClient.GetAll();
            var homeViewModel = new HomeViewModel()
            {
                Banners = banners,
            };
            CreateCartViewBag();
            var productCategory = await _categoryApiClient.GetHomeProductCategories();
            ViewBag.Categories = productCategory;
            return View(homeViewModel);
        }
        protected void CreateCategoryViewBag()
        {
            var productCategory = _categoryApiClient.GetHomeProductCategories();
            ViewBag.Categories = productCategory;
        }
        [HttpGet("ProductInCategory/{categoryId}")]
        public async Task<IActionResult> ProductInCategory([FromQuery] PaginateRequest request, int categoryId )
        {
            var clientId = User.Claims.ToList().Where(x => x.Type == "Id").FirstOrDefault();
            var logout = HttpContext.Session.GetString("Token") == null && clientId != null;
            if (logout)
                return RedirectToAction("Logout", "User");
            await CreateUserViewBag();
            var products = await _categoryApiClient.GetProductInCategory(request, categoryId);

            var cat = await _categoryApiClient.GetById(categoryId);
            if (cat == null)
            {
                return RedirectToAction("Error", "Home");
            }
            ViewBag.Category = cat;
            var productCategory = await _categoryApiClient.GetHomeProductCategories();
            ViewBag.Categories = productCategory;
            return View(products);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
