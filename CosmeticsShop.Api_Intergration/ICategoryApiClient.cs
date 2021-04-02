using Cosmetics.ViewModels.Catalogs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryViewModel>> GetAll();
    }
}
