using CosmeticsShop.Api_Intergration;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmeticsShop.WebApp.Controllers
{
    public class ProductController : ClientBaseController
    {
        private readonly IClientApiProduct _clientApiProduct;
        private readonly IClientApi _clientApi;
        public ProductController(IClientApiProduct clientApiProduct, IClientApi clientApi) : base(clientApi)
        {
            _clientApiProduct = clientApiProduct;
            _clientApi = clientApi;
        }

        [HttpGet("product/{id}")]

        public async Task<IActionResult> Detail([FromRoute]int id)
        {
            if (id < 1)
            {
                return RedirectToAction("Error", "Home");
            }
            var response = await _clientApiProduct.GetProuctDetail(id);

            if (!response.IsSuccess)
            {
                return RedirectToAction("Error", "Home");
            }

            await CreateUserViewBag();
            CreateCartViewBag();
            
            return View(response.ResultObj);
        }


    }
}
