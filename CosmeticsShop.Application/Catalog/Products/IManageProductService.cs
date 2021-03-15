using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Catalogs.Products.Manage;
using Cosmetics.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<PageResponse<ProductViewModel>> GetAllPaging(GetProductRequest query);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task UpdateViewCount(int productId);
        Task<bool> UpdateStock(int productId, int addedStock);
        Task<int> AddImage(int productId, List<IFormFile> files);
        Task<int> RemoveImages(List<int> imageIds);
        Task<int> UpdateImage(int imageId, string caption, bool isDefault);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
        Task<ProductViewModel?> GetById(int id);
    }
}
