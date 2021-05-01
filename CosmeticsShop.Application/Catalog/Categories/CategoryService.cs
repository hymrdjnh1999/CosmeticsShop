using Cosmetics.ViewModels.Catalogs.Categories;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Data.Entities;
using CosmeticsShop.Data.EntityFrameWork;
using CosmeticsShop.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly CosmeticsDbContext _context;
        public CategoryService(CosmeticsDbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(CategoryCreateRequest request)
        {
            var category = new Category()
            {
                Name = request.Name,
                SortOrder = request.SortOrder,
                Status = Status.Active,
                CreatedDate = DateTime.Now
            };
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category.Id;
        }

        public async Task<bool> Edit(CategoryUpdateRequest request)
        {
            var category = await _context.Categories.FindAsync(request.Id);
            if (category == null)
            {
                return false;
            }

            category.Name = request.Name;
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            var query = from c in _context.Categories select c;
            var categories = await query.Select(x => new CategoryViewModel()
            {
                Id = x.Id,
                IsOutstanding = x.IsOutstanding,
                Name = x.Name,
                ParentId = x.ParentId,
                SortOrder = x.SortOrder,
                Status = x.Status
            }).ToListAsync();

            return categories;
        }

        public async Task<PageResponse<CategoryViewModel>> GetAllPaging(PaginateRequest request)
        {
            int PageIndex = request.PageIndex;
            int PageSize = request.PageSize;
            var totalRecords = 0;


            var query = from c in _context.Categories select c;

            if (request.Keyword != null)
            {
                query = query.Where(x => x.Name.Contains(request.Keyword));

            }

            totalRecords = await query.CountAsync();

            var data = await query.Skip((PageIndex - 1) * PageSize)
                .Take(PageSize)
                .Select(x => new CategoryViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Status = x.Status

                })
                .ToListAsync();

            var response = new PageResponse<CategoryViewModel>()
            {
                Items = data,
                TotalRecords = totalRecords,
                PageIndex = PageIndex,
                PageSize = PageSize
            };

            return response;
        }

        public async Task<CategoryViewModel> GetById(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return null;
            }

            var productViewModel = new CategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                SortOrder = category.SortOrder
            };
            return productViewModel;

        }
    }
}
