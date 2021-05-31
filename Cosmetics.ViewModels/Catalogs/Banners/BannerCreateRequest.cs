using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Banners
{
    public class BannerCreateRequest
    {
        public int BannerId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
