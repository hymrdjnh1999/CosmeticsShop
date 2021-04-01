using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Catalogs.Products.Manage;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.AdminApp.Services
{
    public interface IProductApiClient
    {
        Task<PageResponse<ProductViewModel>> GetPaging(GetProductRequest request);
        Task<bool> Create(ProductCreateRequest request);
        Task<ApiResult<bool>> CategoryAssign(CategoryAssignRequest request);
        Task<ProductViewModel> GetById(int id);
    }
}