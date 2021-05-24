using CosmeticsShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OriginalCountry { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Details { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public ForGender ForGender { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<ProductInCosmeticsCollection> ProductInCosmeticsCollections { get; set; }
        public List<ProductInCart> ProductInCarts { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductInProductPrivateProperty> ProductInProductPrivateProperties { get; set; }

    }
}
