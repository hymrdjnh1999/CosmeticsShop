using Cosmetics.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmeticsShop.WebApp.Controllers
{

    public class ServiceController : Controller
    {

        [HttpPost]
        public JsonResult Index(ServiceViewModel service)
        {
            if (!String.IsNullOrEmpty(service.SessionName) && !String.IsNullOrEmpty(service.SessionValue))
            {
                HttpContext.Session.SetString(service.SessionName, service.SessionValue);
            }

            return new JsonResult(new { result = 1 });
        }
    }
}
