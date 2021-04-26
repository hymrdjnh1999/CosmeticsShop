using Cosmetics.ViewModels.Catalogs.ProductImages;
using CosmeticsShop.Api_Intergration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.AdminApp.Controllers
{
    public class ProductImageController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        public ProductImageController(IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;
        }

        [HttpGet("product/{productId}/images/add")]
        public IActionResult Add(int productId)
        {

            if (!ModelState.IsValid || productId == 0)
            {
                return RedirectToAction("Error", "Home");
            }

            var model = new ProductImageCreateRequest()
            {
                ProductId = productId
            };
            return View(model);
        }

        [HttpPost("product/{productId}/images/add")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Add(ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }


            var result = await _productApiClient.AddImage(request);

            if (!result)
            {
                return View(request);
            }

            TempData["result"] = "Thêm ảnh thành công!";
            return LocalRedirect($"/Product/{request.ProductId}/images");
        }
    }
}
