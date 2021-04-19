using Cosmetics.ViewModels.Common;
using CosmeticsShop.Data.Entities;
using CosmeticsShop.Data.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Products.Manage
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public decimal Price { get; set; }
        [DisplayName("Original price")]
        public decimal OriginalPrice { get; set; }
        [DisplayName("For gender")]

        public ForGender ForGender { get; set; }
        [DisplayName("Date created")]
        public DateTime DateCreated { get; set; }
        public int Stock { get; set; }
        [DisplayName("View count")]

        public int ViewCount { get; set; }
        [DisplayName("Original country")]
        public string OriginalCountry { get; set; }
        public IList<string> Categories { get; set; }
        public List<SelectItemDynamic<int>> CategoriesAssignRequest { get; set; }
        = new List<SelectItemDynamic<int>>();
        public IEnumerable<Category> CategoryList { get; set; }
        public string[] SelectedId { get; set; }
        public string ImagePath { get; set; }
        public IFormFile ThumbnailImage { get; set; }

    }
}
