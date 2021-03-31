using Cosmetics.AdminApp.Services;
using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Catalogs.Products.Manage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly ICategoryApiClient _categoryApiClient;
        public ProductController(IProductApiClient productApiClient,
            IConfiguration config,
            ICategoryApiClient categoryApiClient)
        {
            _config = config;
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }


        public async Task<IActionResult> Index([FromQuery] GetProductRequest request)
        {


            var data = await _productApiClient.GetPaging(request);
            ViewBag.Keyword = request.Keyword;
            var categories = await _categoryApiClient.GetAll();
            if (categories != null)
            {
                ViewBag.Categories = categories.Select(x => new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.Id.ToString(),
                    Selected = request.CategoryId.HasValue && request.CategoryId.Value == x.Id
                });
            }

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
