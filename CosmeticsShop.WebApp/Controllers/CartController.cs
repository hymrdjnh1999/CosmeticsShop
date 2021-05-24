using Cosmetics.ViewModels.Catalogs.Carts;
using Cosmetics.ViewModels.Catalogs.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmeticsShop.WebApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CartDetail()
        {
            return View();
        }
        public IActionResult InforOrder()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddToCart([FromBody] ProductInCartViewModel productCart)
        {
            var cartJS = HttpContext.Session.GetString("Cart");
            ClientCartViewModel cart;

            if (cartJS != null)
            {
                cart = JsonConvert.DeserializeObject<ClientCartViewModel>(cartJS);
                var product = cart.Products.Where(x => x.Id == productCart.Id).FirstOrDefault();
                if (product != null)
                {
                    product.Quantity += productCart.Quantity;
                    product.ProductPrice *= product.Quantity;
                }
                else
                {
                    cart.Products.Add(productCart);
                }
                cartJS = JsonConvert.SerializeObject(cart);
                HttpContext.Session.SetString("Cart", cartJS);
            }
            else
            {
                cart = new ClientCartViewModel();
                cart.Products.Add(productCart);
                HttpContext.Session.SetString("Cart", cartJS);
            }
            return new JsonResult(cart);
        }
    }
}
