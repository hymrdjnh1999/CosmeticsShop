using Cosmetics.ViewModels.Catalogs.Categories;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAll();
        Task<PageResponse<CategoryViewModel>> GetAllPaging(PaginateRequest request);
        Task<CategoryViewModel> GetById(int id);
        Task<int> Create(CategoryCreateRequest request);

    }
}
