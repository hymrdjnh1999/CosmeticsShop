using Cosmetics.Ultilities.Exceptions;
using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Catalogs.Products.Manage;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Application.Common;
using CosmeticsShop.Data.Entities;
using CosmeticsShop.Data.EntityFrameWork;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly CosmeticsDbContext _context;
        private readonly IStorageService _storageService;
        public ManageProductService(CosmeticsDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public Task<int> AddImage(int productId, List<IFormFile> files)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                Name = request.Name,
                ForGender = request.ForGender,
                OriginalCountry = request.OriginalCountry,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                Description = request.Description,
                Details = request.Details,
                ViewCount = 0,
                DateCreated = DateTime.Now,
            };

            if (request.ThumbnailImage != null)
            {
                product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Caption= "Thumbnail image",
                        DateCreated = DateTime.Now,
                        FileSize = request.ThumbnailImage.Length,
                        IsDefault = true,
                        SortOrder = 1,
                        ImagePath = await this.SaveFile(request.ThumbnailImage)
                    }
                };
            }

            _context.Products.Add(product);

            await _context.SaveChangesAsync();
            return product.Id;

        }

        public async Task<int?> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return null;
            }

            var images = await _context.ProductImages.Where(x => x.IsDefault == true && x.ProductId == productId).ToListAsync();

            foreach (var item in images)
            {
                await _storageService.DeleteFileAsync(item.ImagePath);
            }
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<PageResponse<ProductViewModel>> GetAllPaging(GetProductRequest query)
        {
            var queryResult = from p in _context.Products
                              join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                              join c in _context.Categories on pic.CategoryId equals c.Id
                              select new { p, pic };
            if (!string.IsNullOrEmpty(query.SearchKeyWord))
            {
                queryResult = queryResult.Where(x => x.p.Name.Contains(query.SearchKeyWord));
            }
            if (query.CategoryIds.Count > 0)
            {
                queryResult = queryResult.Where(p => query.CategoryIds.Contains(p.pic.CategoryId));
            }
            int totalRow = await queryResult.CountAsync();

            int PageIndex = query.PageIndex ?? 1;
            int PageSize = query.PageSize ?? 10;

            var data = await queryResult.Skip((PageIndex - 1) * PageSize)
                .Take(PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.p.Name,
                    Price = x.p.Price,
                    ForGender = x.p.ForGender,
                    OriginalPrice = x.p.OriginalPrice,
                    DateCreated = x.p.DateCreated,
                    Description = x.p.Description,
                    Details = x.p.Details,
                    OriginalCountry = x.p.OriginalCountry,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount
                }).ToListAsync();

            var pagedResult = new PageResponse<ProductViewModel>()
            {
                Items = data,
                TotalRecords = totalRow,
                Skip = (PageIndex - 1) * PageSize,
                Take = PageSize,

            };
            return pagedResult;

        }

        public async Task<ProductViewModel?> GetById(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null) return null;
            var productViewModel = new ProductViewModel()
            {
                Id = product.Id,
                DateCreated = product.DateCreated,
                Description = product.Description,
                Details = product.Details,
                ForGender = product.ForGender,
                Name = product.Name,
                OriginalCountry = product.OriginalCountry,
                OriginalPrice = product.OriginalPrice,
                Price = product.Price,
                Stock = product.Stock,
                ViewCount = product.ViewCount
            };
            return productViewModel;
        }

        public Task<List<ProductImageViewModel>> GetListImage(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveImages(List<int> imageIds)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (product == null)
                throw new CosmeticsException("Không tìm thấy sản phẩm này");
            product.Name = request.Name;
            product.IsOutstanding = request.IsOutstanding ?? false;
            product.OriginalCountry = request.OriginalCountry;
            product.ForGender = request.ForGender;
            product.Description = request.Description;

            if (request.ThumbnailImage != null)
            {
                if (product.ProductInCategories != null)
                {
                    var thumbnail = await _context.ProductImages.FirstOrDefaultAsync(x => x.IsDefault == true && x.ProductId == request.Id);
                    if (thumbnail != null)
                    {
                        thumbnail.FileSize = request.ThumbnailImage.Length;
                        thumbnail.ImagePath = await SaveFile(request.ThumbnailImage);
                        _context.ProductImages.Update(thumbnail);
                    }
                }
                else
                {
                    product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Caption= "Thumbnail image",
                        DateCreated = DateTime.Now,
                        FileSize = request.ThumbnailImage.Length,
                        IsDefault = true,
                        SortOrder = 1,
                        ImagePath = await SaveFile(request.ThumbnailImage)
                    }
                };
                }

            }
            return await _context.SaveChangesAsync();

        }

        public Task<int> UpdateImage(int imageId, string caption, bool isDefault)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == productId);
            if (product == null)
                throw new CosmeticsException("Không tìm thấy sản phẩm này");
            product.Price = newPrice;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateStock(int productId, int addedStock)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == productId);
            if (product == null)
                throw new CosmeticsException("Không tìm thấy sản phẩm này");
            product.Stock += addedStock;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task UpdateViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
