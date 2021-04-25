using Cosmetics.ViewModels.Catalogs.ProductImages;
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

        [HttpPost]
        [Consumes("multipart/form-data")]
        public IActionResult Add(ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            return LocalRedirect($"/Product/{request.ProductId}/images");
        }
    }
}
