using Cosmetics.ViewModels.Catalogs.Carts;
using Cosmetics.ViewModels.Systems.Clients;
using CosmeticsShop.Api_Intergration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IClientApi _clientApi;
        private readonly ICartApiClient _cartApiClient;
        public UserController(IClientApi clientApi, IConfiguration configuration, ICartApiClient cartApiClient)
        {
            _clientApi = clientApi;
            _config = configuration;
            _cartApiClient = cartApiClient;
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Login()
        {
            var sessions = HttpContext.Session.GetString("Token");
            if (sessions != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(ClientLoginRequest request)
        {
            var sessions = HttpContext.Session.GetString("Token");
            if (sessions != null)
            {
                return RedirectToAction("Index", "Home");
            }
            var apiResult = await _clientApi.Login(request);
            if (!apiResult.IsSuccess)
            {
                ViewBag.Error = apiResult.ResultObj;
                return View(request);
            }

            var userPrincipal = ValidateToken(apiResult.ResultObj);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(1),
                IsPersistent = true
            };

            HttpContext.Session.SetString("Token", apiResult.ResultObj);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                userPrincipal,
                authProperties);
            var cartJs = HttpContext.Session.GetString("Cart");
            if (cartJs != null)
            {
                var clientId = User.Claims.Where(x => x.Type == "Id").FirstOrDefault().Value;
                var cart = JsonConvert.DeserializeObject<ClientCartViewModel>(cartJs);
                cart.ClientId = new Guid(clientId);
                cart = await _cartApiClient.AddToCart(cart);
                ViewBag.Cart = cart;
            }


            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            var sessions = HttpContext.Session.GetString("Token");
            if (sessions != null)
            {
                return RedirectToAction("Index", "Home");
            }


            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(ClientRegisterRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            var apiResult = await _clientApi.Register(request);
            if (!apiResult.IsSuccess)
            {
                ViewBag.Error = apiResult.ResultObj ?? apiResult.Message;
                return View(request);
            }
            var userPrincipal = ValidateToken(apiResult.ResultObj);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(1),
                IsPersistent = true
            };

            HttpContext.Session.SetString("Token", apiResult.ResultObj);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                userPrincipal,
                authProperties);
            var cartJs = HttpContext.Session.GetString("Cart");
            if (cartJs != null)
            {
                var cart = JsonConvert.DeserializeObject<ClientCartViewModel>(cartJs);
                ViewBag.Cart = cart;
            }
            return RedirectToAction("Index", "Home");
        }
        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;

            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = _config["Tokens:Issuer"];
            validationParameters.ValidIssuer = _config["Tokens:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));

            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return principal;
        }
    }
}