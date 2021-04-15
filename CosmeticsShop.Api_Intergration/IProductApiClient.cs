using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Catalogs.Products.Manage;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public interface IProductApiClient
    {
        Task<PageResponse<ProductViewModel>> GetPaging(GetProductRequest request);
        Task<bool> Create(ProductCreateRequest request);
        Task<bool> Update(ProductUpdateRequest request);
        Task<ApiResult<bool>> CategoryAssign(CategoryAssignRequest request);
        Task<ProductUpdateRequest> GetById(int id);
        Task<List<ProductViewModel>> GetFeaturedProducts();
    }
}