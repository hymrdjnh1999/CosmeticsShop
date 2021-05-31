using Cosmetics.ViewModels.Catalogs.Carts;
using Cosmetics.ViewModels.Catalogs.Orders;
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
        private readonly IClientOrderApi _clientOrderApi;
        private ClientCartViewModel GetCartViewModel()
        {
            var cartJS = HttpContext.Session.GetString("Cart");
            if (cartJS == null) { return null; }
            var cart = JsonConvert.DeserializeObject<ClientCartViewModel>(cartJS);
            return cart;
        }
        public CartController(ICartApiClient cartApiClient, IClientOrderApi clientOrderApi)
        {
            _cartApiClient = cartApiClient;
            _clientOrderApi = clientOrderApi;
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
            ViewBag.Cart = cart;
            return View();
        }

        [HttpGet("{cartId}/thanks/{orderId}")]
        public async Task<IActionResult> Bill(Guid cartId, int orderId)
        {
            var cart = GetCartViewModel();

            if (cart != null)
            {
                HttpContext.Session.Remove("Cart");
            }

            if (orderId < 1)
            {
                return RedirectToAction("Error", "Home");
            }

            var order = await _clientOrderApi.GetOrder(cartId, orderId);

            if (!order.IsSuccess)
            {
                return RedirectToAction("Error", "Home");
            }
            var clientCart = await _cartApiClient.GetCart(cartId);
            ViewBag.Order = order.ResultObj;
            ViewBag.Cart = clientCart.ResultObj;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> InforOrder(ClientCreateOrderViewModel request)
        {

            var cart = GetCartViewModel();
            ViewBag.Cart = cart;
            request.ClientCart = cart;
            var isLogin = HttpContext.Session.GetString("Token");
            ViewBag.isLogin = false;
            if (isLogin != null)
            {
                ViewBag.isLogin = true;
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _clientOrderApi.ClientCreateOrder(request);
            if (result < 1)
            {
                return View();
            }
            return RedirectToAction("bill", new { orderId = result, cartId = cart.Id });
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
                }
              
                cart.CartPrice = cart.Products.Sum(x => x.ProductPrice * x.Quantity);
                cart = await _cartApiClient.AddToCart(cart);
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

                }
                cart = await _cartApiClient.AddToCart(cart);
                var serializeCart = JsonConvert.SerializeObject(cart);
                HttpContext.Session.SetString("Cart", serializeCart);
            }
            return new JsonResult(cart);
        }
    }
}
