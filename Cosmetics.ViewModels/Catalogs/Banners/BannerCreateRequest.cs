using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Banners
{
    class BannerCreateRequest
    {
        public string Description { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
