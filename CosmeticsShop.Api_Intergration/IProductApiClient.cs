﻿using Cosmetics.ViewModels.Catalogs.ProductImages;
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
        Task<PageResponse<ProductViewModel>> GetPaging(GetProductRequest request , string status);
        Task<ProductUpdateRequest> Create(ProductCreateRequest request);
        Task<bool> Update(ProductUpdateRequest request);
        Task<bool> Delete(int product_id);
        Task<ApiResult<bool>> CategoryAssign(CategoryAssignRequest request);
        Task<ProductUpdateRequest> GetById(int id);
        Task<PageResponse<ProductImageViewModel>> GetProductImages(int productId, QueryParamRequest request);
        Task<bool> AddImage(ProductImageCreateRequest request);
        Task<bool> ChangeThumbnail(int imageId, int productId);
        Task<bool> UpdateProductImage(ProductImageUpdateRequest request);
        Task<ProductImageViewModel> GetImageById(int productId, int imageId);
        Task<ApiResult<bool>> DeleteImage(int productId, int imageId);
        Task<PageResponse<ProductViewModel>> SearchProduct(GetProductRequest request);
    }
}