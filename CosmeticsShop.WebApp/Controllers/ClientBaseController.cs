using Microsoft.AspNetCore.Mvc;
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
        private Claim GetClaim(string type)
        {
            var userClaims = User.Claims.ToList();

            return userClaims.Where(x => x.Type == type).FirstOrDefault();

        }

    }
}
