﻿using Cosmetics.ViewModels.Catalogs.Categories;
using Cosmetics.ViewModels.Catalogs.Products;
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
        Task<List<HomeCategoryViewModel>> GetHomeProductCategories();

        Task<PageResponse<ProductViewModel>> GetProductInCategory(PaginateRequest request , int categoryId);
        Task<PageResponse<CategoryViewModel>> GetAllPaging(PaginateRequest request , string status);
        Task<PageResponse<ProductViewModel>> Search(PaginateRequest request, string categoryId);
        Task<int> Create(CategoryCreateRequest request);
        Task<bool> Edit(CategoryUpdateRequest request);
        Task<CategoryViewModel> GetById(int id);
        Task<bool> Delete(int id);

    }
}
