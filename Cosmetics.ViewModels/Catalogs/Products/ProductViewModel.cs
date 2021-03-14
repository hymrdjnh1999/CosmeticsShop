using CosmeticsShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Products
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public ForGender? ForGender { get; set; }
        public DateTime DateCreated { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public string OriginalCountry { get; set; }


    }
}
