using Cosmetics.ViewModels.Catalogs.Categories;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Api_Intergration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Cosmetics.AdminApp.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryApiClient _categoryApiClient;
        private readonly IConfiguration _config;

        public CategoryController(ICategoryApiClient categoryApiClient, IConfiguration configuration)
        {
            _config = configuration;
            _categoryApiClient = categoryApiClient;
        }
        public async Task<IActionResult> Index(string keyword = "", int pageSize = 10, int pageIndex = 1)
        {
            var paginateRequest = new PaginateRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };

            var categories = await _categoryApiClient.GetAllPaging(paginateRequest);
            ViewBag.Keyword = paginateRequest.Keyword;

            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }

            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _categoryApiClient.Create(request);

            if (result > 0)
            {
                TempData["result"] = "Create category successfully!";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Create category failed!");
            return View(request);
        }

    }
}
