using Cosmetics.AdminApp.Services;
using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Catalogs.Products.Manage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.AdminApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _config;
        public ProductController(IProductApiClient productApiClient,
            IConfiguration config)
        {
            _config = config;
            _productApiClient = productApiClient;
        }


        public async Task<IActionResult> Index(string keyword = "", int pageIndex = 1, int pageSize = 10, int categoryId = 1)
        {

            var request = new GetProductRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                CategoryId = categoryId
            };

            var data = await _productApiClient.GetPaging(request);
            ViewBag.Keyword = keyword;
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _productApiClient.Create(request);
            if (result)
            {
                TempData["result"] = "Create product successfully!";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Create product failed!");
            return View(request);
        }
    }
}
