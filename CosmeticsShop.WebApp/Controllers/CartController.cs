using Cosmetics.ViewModels.Catalogs.Carts;
using Cosmetics.ViewModels.Catalogs.Products;
using CosmeticsShop.Api_Intergration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CosmeticsShop.WebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartApiClient _cartApiClient;
        public CartController(ICartApiClient cartApiClient)
        {
            _cartApiClient = cartApiClient;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CartDetail()
        {
            var cartJS = HttpContext.Session.GetString("Cart");
            if (cartJS != null)
            {
                var cart = JsonConvert.DeserializeObject<ClientCartViewModel>(cartJS);
                ViewBag.Cart = cart;
            }
            return View();
        }
        [HttpGet]
        public IActionResult InforOrder()
        {
            var isLogin = HttpContext.Session.GetString("Token");
            ViewBag.isLogin = false;
            if (isLogin != null)
            {
                ViewBag.isLogin = true;
            }
            var cartJS = HttpContext.Session.GetString("Cart");
            if (cartJS == null)
            {
                return RedirectToAction("CartDetail", "Cart");
            }
            var cart = JsonConvert.DeserializeObject<ClientCartViewModel>(cartJS);
            ViewBag.CartDetail = cart;
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> AddToCart([FromBody] ProductInCartViewModel productCart)
        {
            var cartJS = HttpContext.Session.GetString("Cart");
            ClientCartViewModel cart;
            var token = HttpContext.Session.GetString("Token");

            if (cartJS != null)
            {
                cart = JsonConvert.DeserializeObject<ClientCartViewModel>(cartJS);
                var product = cart.Products.Where(x => x.Id == productCart.Id).FirstOrDefault();
                if (product != null)
                {
                    product.Quantity += productCart.Quantity;
                }
                else
                {
                    cart.Products.Add(productCart);
                }

                if (token != null)
                {
                    var clientId = User.Claims.ToList().Where(x => x.Type == "Id").FirstOrDefault().Value;
                    cart.ClientId = new Guid(clientId);
                    cart = await _cartApiClient.AddToCart(cart);

                }
                cart.CartPrice = cart.Products.Sum(x => x.ProductPrice * x.Quantity);
                cartJS = JsonConvert.SerializeObject(cart);
                HttpContext.Session.SetString("Cart", cartJS);
            }
            else
            {
                cart = new ClientCartViewModel();

                cart.Products.Add(productCart);
                cart.CartPrice = productCart.ProductPrice;
                if (token != null)
                {
                    var clientId = User.Claims.ToList().Where(x => x.Type == "Id").FirstOrDefault().Value;
                    cart.ClientId = new Guid(clientId);
                    cart = await _cartApiClient.AddToCart(cart);

                }
                var serializeCart = JsonConvert.SerializeObject(cart);
                HttpContext.Session.SetString("Cart", serializeCart);
            }
            return new JsonResult(cart);
        }
    }
}
