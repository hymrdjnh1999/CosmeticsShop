using CosmeticsShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Categories
{
    public class CategoryCreateRequest
    {
        public string Name { get; set; }
        public int SortOrder { get; set; }

    }
}
