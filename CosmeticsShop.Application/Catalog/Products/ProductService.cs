using Cosmetics.Ultilities.Exceptions;
using Cosmetics.ViewModels.Catalogs.ProductImages;
using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Catalogs.Products.Manage;
using Cosmetics.ViewModels.Catalogs.Products.Public;
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
    public class ProductService : IProductService
    {
        private readonly CosmeticsDbContext _context;
        private readonly IStorageService _storageService;
        public ProductService(CosmeticsDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<int> AddImage(int productId, ProductImageCreateRequest request)
        {

            if (request.ImageFile == null)
            {
                throw new CosmeticsException("Error");
            }
            var image = new ProductImage()
            {
                Caption = request.Caption,
                DateCreated = DateTime.Now,
                FileSize = request.ImageFile.Length,
                ImagePath = await SaveFile(request.ImageFile),
                IsDefault = request.IsDefault,
                ProductId = productId,
                SortOrder = request.SortOrder
            };
            _context.ProductImages.Add(image);
            await _context.SaveChangesAsync();
            return image.Id;

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
                Description = request.Description ?? "",
                Details = request.Details ?? "",
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

        public async Task<PageResponse<ProductViewModel>> GetAll(GetProductRequest request)
        {
            int PageIndex = request.PageIndex;
            int PageSize = request.PageSize;
            var totalRecords = 0;
            if (request.CategoryId == null)
            {
                var result = from p in _context.Products select p;

                if (request.Keyword != null)
                {
                    result = result.Where(x => x.Name.Contains(request.Keyword));

                }
                totalRecords = await result.CountAsync();

                var products = await result.Skip((PageIndex - 1) * PageSize).Take(PageSize).Select(x => new ProductViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    ForGender = x.ForGender,
                    OriginalPrice = x.OriginalPrice,
                    DateCreated = x.DateCreated,
                    Description = x.Description,
                    Details = x.Details,
                    OriginalCountry = x.OriginalCountry,
                    Stock = x.Stock,
                    ViewCount = x.ViewCount
                }).ToListAsync();
                var responseData = new PageResponse<ProductViewModel>()
                {
                    Items = products,
                    TotalRecords = totalRecords,
                    PageIndex = PageIndex,
                    PageSize = PageSize
                };

                return responseData;

            }

            var query = from p in _context.Products
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pic, c };

            query = query.Where(p => p.pic.CategoryId == request.CategoryId);

            if (request.Keyword != null)
            {
                query = query.Where(x => x.p.Name.Contains(request.Keyword));

            }
            totalRecords = await query.Select(x => x.p).CountAsync();

            var data = await query.Skip((PageIndex - 1) * PageSize)
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
                })
                .ToListAsync();

            var response = new PageResponse<ProductViewModel>()
            {
                Items = data,
                TotalRecords = totalRecords,
                PageIndex = PageIndex,
                PageSize = PageSize
            };

            return response;
        }

        public async Task<ProductViewModel> GetById(int id)
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

        public async Task<ProductImageViewModel> GetImageById(int id)
        {
            var image = await _context.ProductImages.FirstOrDefaultAsync(x => x.Id == id);
            if (image == null) return null;
            var productImageViewModel = new ProductImageViewModel()
            {
                Id = image.Id,
                Caption = image.Caption,
                DateCreated = image.DateCreated,
                FileSize = image.FileSize,
                ImagePath = image.ImagePath,
                IsDefault = image.IsDefault,
                ProductId = image.ProductId,
                SortOrder = image.SortOrder
            };
            return productImageViewModel;
        }

        public async Task<List<ProductImageViewModel>> GetListImage(int productId)
        {
            var images = await _context.ProductImages
                .Where(x => x.ProductId == productId)
                .Select(x => new ProductImageViewModel()
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    Caption = x.Caption,
                    DateCreated = x.DateCreated,
                    FileSize = x.FileSize,
                    ImagePath = x.ImagePath,
                    IsDefault = x.IsDefault,
                    SortOrder = x.SortOrder
                }
                )
                .ToListAsync();
            return images;
        }

        public async Task<int> RemoveImage(int imageId)
        {
            var image = await _context.ProductImages.FindAsync(imageId);
            if (image == null) throw new CosmeticsException($"Không tìm thấy ảnh với id: {imageId}");
            _context.ProductImages.Remove(image);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (product == null)
                throw new CosmeticsException("Không tìm thấy sản phẩm này");
            product.Name = request.Name;
            product.IsOutstanding = request.IsOutstanding;
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

        public async Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request)
        {

            var productImage = await _context.ProductImages.FindAsync(imageId);
            if (productImage == null || request.ImageFile == null)
            {
                throw new CosmeticsException("Error");
            }
            productImage.ImagePath = await SaveFile(request.ImageFile);
            productImage.FileSize = request.ImageFile.Length;
            productImage.Caption = request.Caption;
            productImage.IsDefault = request.IsDefault;
            productImage.SortOrder = request.SortOrder;
            _context.ProductImages.Update(productImage);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool?> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == productId);
            if (product == null)
                return null;
            product.Price = newPrice;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool?> UpdateStock(int productId, int addedStock)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == productId);
            if (product == null)
                return null;
            product.Stock += addedStock;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool?> UpdateViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return null;
            product.ViewCount += 1;
            return await _context.SaveChangesAsync() > 0;
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
