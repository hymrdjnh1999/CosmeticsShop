using Cosmetics.ViewModels.Catalogs.Categories;
using CosmeticsShop.Data.EntityFrameWork;
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
    }
}
