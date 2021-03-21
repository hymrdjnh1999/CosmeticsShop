using CosmeticsShop.Data.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Products.Manage
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string OriginalCountry { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Details { get; set; }
        public int Stock { get; set; }
        public int? ViewCount { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? IsOutstanding { get; set; }
        public ForGender? ForGender { get; set; }
        public IFormFile ThumbnailImage { get; set; }
    }
}
