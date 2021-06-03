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
        public HomeController(ILogger<HomeController> logger, ISlideApiClient slideApiClient, IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _logger = logger;
            _slideApiClient = slideApiClient;
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index()
        {
            CreateUserViewBag();
            var slides = await _slideApiClient.GetAll();
            var productCategory = await _categoryApiClient.GetHomeProductCategories();
            var homeViewModel = new HomeViewModel()
            {
                Slides = slides,
            };
            var cartJs = HttpContext.Session.GetString("Cart");
            if (cartJs != null)
            {
                var cart = JsonConvert.DeserializeObject(cartJs);
                ViewBag.Cart = cart;
            }

            ViewBag.Categories = productCategory;
            return View(homeViewModel);
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
