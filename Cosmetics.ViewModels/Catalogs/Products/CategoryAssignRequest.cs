using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.ViewModels.Catalogs.Products
{
    public class CategoryAssignRequest
    {
        public int Id { get; set; }
        public List<SelectItemDynamic<int>> Categories { get; set; } = new List<SelectItemDynamic<int>>();
        public string[] SelectedCategories { get; set; }
        public IEnumerable<SelectItemDynamic<int>> ListCategory
        {
            get
            {
                return Categories;
            }
        }
    }
}
