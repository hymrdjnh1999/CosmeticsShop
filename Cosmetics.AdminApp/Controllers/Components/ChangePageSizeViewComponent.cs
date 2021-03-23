using Cosmetics.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.AdminApp.Controllers.Components
{
    public class ChangePageSizeViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PageResponseBase request)
        {
            return Task.FromResult((IViewComponentResult)View("ChangePageSize", request));
        }

    }
}
