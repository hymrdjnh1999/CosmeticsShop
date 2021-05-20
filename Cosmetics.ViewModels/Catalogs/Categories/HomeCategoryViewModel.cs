using Cosmetics.ViewModels.Catalogs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Categories
{
    public class HomeCategoryViewModel
    {
        public List<HomeProductViewModel> Products { get; set; }
        public string CategoryName { get; set; }
    }
}
