using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Catalogs.Products.Manage;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Api_Intergration;
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


        public async Task<IActionResult> Index(GetProductRequest request)
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


        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var categoryAssignRequest = await GetCategoryAssignRequest(id);
            var product = await _productApiClient.GetById(id);
            product.CategoriesAssignRequest = categoryAssignRequest.Categories;


            return View(product);
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Update([FromForm] ProductViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _productApiClient.Update(request);
            if (result)
            {
                var categoryRequest = new CategoryAssignRequest()
                {
                    Categories = request.CategoriesAssignRequest,
                    Id = request.Id
                };

                var categoryAssignResult = await _productApiClient.CategoryAssign(categoryRequest);
                if (categoryAssignResult.IsSuccess)
                {
                    TempData["result"] = "Update product successfully!";
                    return RedirectToAction("Index");
                }

            }
            ModelState.AddModelError("", "Update product failed!");
            return RedirectToAction("Details", request.Id);
        }

        //[HttpGet]
        //public async Task<IActionResult> CategroryAssign(int id)
        //{

        //    var categoryAssignRequest = await GetCategoryAssignRequest(id);

        //    return View(categoryAssignRequest);

        //}

        //[HttpPost]
        //public async Task<IActionResult> CategroryAssign(CategoryAssignRequest request)
        //{
        //    if (!ModelState.IsValid)
        //        return View();



        //    if (result.IsSuccess)
        //    {
        //        TempData["result"] = "Role assign successfully";
        //        return RedirectToAction("Index");
        //    }

        //    ModelState.AddModelError("", result.Message);
        //    var categoryAssignRequest = await GetCategoryAssignRequest(request.Id);

        //    return View(categoryAssignRequest);
        //}
        private async Task<CategoryAssignRequest> GetCategoryAssignRequest(int id)
        {
            var productViewModel = await _productApiClient.GetById(id);
            var categories = await _categoryApiClient.GetAll();
            var categoryAssignRequest = new CategoryAssignRequest();
            categoryAssignRequest.Id = id;

            foreach (var category in categories)
            {
                categoryAssignRequest.Categories.Add(new SelectItemDynamic<int>()
                {
                    Id = category.Id,
                    Name = category.Name,
                    Selected = productViewModel.Categories.Contains(category.Name)
                });
            }
            return categoryAssignRequest;
        }
    }
}
