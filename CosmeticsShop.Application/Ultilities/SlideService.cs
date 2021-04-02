using Cosmetics.ViewModels.Ultilities;
using CosmeticsShop.Application.Common;
using CosmeticsShop.Data.EntityFrameWork;
using CosmeticsShop.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Ultilities
{
    public class SlideService : ISlideService
    {
        private readonly CosmeticsDbContext _context;
        private readonly IStorageService _storageService;
        public SlideService(CosmeticsDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<List<SlideViewModel>> GetAll()
        {
            var slides = await _context.Sliders.Where(x => x.Status != Status.InActive).Select(x => new SlideViewModel()
            {
                Id = x.Id,
                Description = x.Description,
                Image = x.Image,
                Name = x.Name,
                SortOrder = x.SortOrder,
                Status = x.Status,
                Url = x.Url
            }).OrderBy(x => x.SortOrder).ToListAsync();

            return slides;
        }
    }
}
