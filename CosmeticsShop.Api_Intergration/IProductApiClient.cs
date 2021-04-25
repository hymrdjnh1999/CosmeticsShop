using Cosmetics.ViewModels.Catalogs.ProductImages;
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
        Task<ProductUpdateRequest> Create(ProductCreateRequest request);
        Task<bool> Update(ProductUpdateRequest request);
        Task<bool> Delete(int product_id);
        Task<ApiResult<bool>> CategoryAssign(CategoryAssignRequest request);
        Task<ProductUpdateRequest> GetById(int id);
        Task<List<ProductViewModel>> GetFeaturedProducts();

        Task<PageResponse<ProductImageViewModel>> GetProductImages(int productId, QueryParamRequest request);
    }
}