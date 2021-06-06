using Cosmetics.ViewModels.Catalogs.Carts;
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
    public class ClientBaseController : Controller
    {
        protected void CreateUserViewBag()
        {
            var result = GetClaim("Id");
            ViewBag.IsLogin = result != null;
            if (result != null)
            {
                result = GetClaim("Avatar");
                ViewBag.Avatar = result != null && !String.IsNullOrEmpty(result.Value) ? $"https://localhost:5001/user-content/{result.Value}" : "/images/default.jpg";
                result = GetClaim("Name");
                ViewBag.Name = result.Value;
            }
        }
        protected void CreateCartViewBag()
        {
            var cartJs = HttpContext.Session.GetString("Cart");
            if (cartJs != null)
            {
                var cart = JsonConvert.DeserializeObject(cartJs);
                ViewBag.Cart = cart;
            }
        }
        protected ClientCartViewModel GetCartViewModel()
        {
            var cartJS = HttpContext.Session.GetString("Cart");
            if (cartJS == null) { return null; }
            var cart = JsonConvert.DeserializeObject<ClientCartViewModel>(cartJS);
            return cart;
        }
        private Claim GetClaim(string type)
        {
            var userClaims = User.Claims.ToList();

            return userClaims.Where(x => x.Type == type).FirstOrDefault();

        }

    }
}
