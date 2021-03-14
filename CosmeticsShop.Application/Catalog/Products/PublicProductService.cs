using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Catalogs.Products.Public;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Data.EntityFrameWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {

        private readonly CosmeticsDbContext _context;
        public PublicProductService(CosmeticsDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            var queryResult = from p in _context.Products
                              select p;

            var data = await queryResult
                .Select(x => new ProductViewModel()
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
            return data;
        }

        public async Task<PageResponse<ProductViewModel>> GetAllByCategoryId(PublicPagingRequest request)
        {
            var queryResult = from p in _context.Products
                              join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                              join c in _context.Categories on pic.CategoryId equals c.Id
                              select new { p, pic };

            if (request.CategoryId != null)
            {
                queryResult = queryResult.Where(p => p.pic.CategoryId == request.CategoryId);
            }



            int totalRow = await queryResult.CountAsync();

            int PageIndex = request.PageIndex ?? 1;
            int PageSize = request.PageSize ?? 10;

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
    }
}
