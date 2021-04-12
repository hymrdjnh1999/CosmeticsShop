using Cosmetics.ViewModels.Catalogs.Categories;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryViewModel>> GetAll();

        Task<PageResponse<CategoryViewModel>> GetAllPaging(PaginateRequest request);

        Task<int> Create(CategoryCreateRequest request);
    }
}
