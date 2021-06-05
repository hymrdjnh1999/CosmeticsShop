using CosmeticsShop.Data.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Banners
{
    public class BannerUpdateRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public Status Status { get; set; }
        public IFormFile ImageFile { get; set; }
       
    }
}
