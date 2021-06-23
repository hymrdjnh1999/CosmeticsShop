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

        [HttpGet("category/create")]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost("category/create")]
        public async Task<IActionResult> Create(CategoryCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _categoryApiClient.Create(request);

            if (result > 0)
            {
                TempData["result"] = "Tạo danh mục thành công!";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Tạo danh mục thất bại!");
            return View(request);
        }


        [HttpGet("category/{id}")]
        public async Task<IActionResult> Edit(int id)
        {

            var category = await _categoryApiClient.GetById(id);
            if (category == null)
            {
                return RedirectToAction("Error", "Home");
            }
            var model = new CategoryUpdateRequest() { Id = id, Name = category.Name , IsOutstanding = category.IsOutstanding };
            return View(model);
        }

        [HttpPost("category/{id}")]
        public async Task<IActionResult> Edit(CategoryUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var result = await _categoryApiClient.Edit(request);

            if (result)
            {
                TempData["result"] = "Cập nhật danh mục thành công";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Cập nhật danh mục thất bại!");
            return View(request);
        }
        [HttpDelete]
        public async Task Delete(int id)
        {

            var category = await _categoryApiClient.GetById(id);
            if (category == null)
            {

                RedirectToAction("Error", "Home");
            }
            else
            {
                var result = await _categoryApiClient.Delete(id);

                if (result)
                {
                    TempData["result"] = "Xóa danh mục thành công";
                    RedirectToAction("Index");
                }
                else
                {

                    TempData["error"] = "Xóa danh mục thất bại";
                    RedirectToAction("Index");
                }

            }
        }


      
    }
}
