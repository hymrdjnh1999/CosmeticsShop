using Cosmetics.ViewModels.Systems.Clients;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmeticsShop.WebApp.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(ClientRegisterRequest request)
        {
            if (!ModelState.IsValid)
                return View(request);

            return RedirectToAction("Index", "Home");
        }
    }
}