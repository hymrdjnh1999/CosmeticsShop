using Cosmetics.Ultilities.Exceptions;
using Cosmetics.ViewModels.Catalogs.Banners;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Application.Common;
using CosmeticsShop.Data.Entities;
using CosmeticsShop.Data.EntityFrameWork;
using CosmeticsShop.Data.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Banners
{
    public class BannerService : IBannerService
    {
        private readonly CosmeticsDbContext _context;
        private readonly IStorageService _storageService;

        public BannerService(CosmeticsDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }
        public async Task<int> Create(BannerCreateRequest request)
        {
            if (request.ImageFile == null)
            {
                throw new CosmeticsException("Error");
            }
            var banner = new Banner()
            {
                Name = request.Name,
                Description = request.Description ?? "Banner Images",
                DateCreated = DateTime.Now,
                FileSize = request.ImageFile.Length,
                IsDefault = true,
                IsOutstanding = true,
                SortOrder = 1,
                Status = Status.Active,
                ImagePath = await this.SaveFile(request.ImageFile)
            };
            _context.Banners.Add(banner);
            await _context.SaveChangesAsync();

            return banner.Id;

        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }



        public async Task<List<BannerViewModel>> GetAll()
        {
            var query = from b in _context.Banners select b;
            query = query.Where(x => x.IsOutstanding == true);
            var banners = await query.Select(x => new BannerViewModel()
            {
                Id = x.Id,
                ImagePath = x.ImagePath,
                Description = x.Description,
                IsDefault = x.IsDefault,
                DateCreated = x.DateCreated,
                Name = x.Name,
                SortOrder = x.SortOrder,
                Status = x.Status,
                IsOutstanding = x.IsOutstanding
            }).ToListAsync();

            return banners;
        }




        public async Task<BannerUpdateRequest> GetById(int id)
        {
            var banner = await _context.Banners.FindAsync(id);
            if (banner == null) return null;
            var bannerViewModel = new BannerUpdateRequest()
            {
                Id = banner.Id,
                Description = banner.Description,
                ImagePath = banner.ImagePath,
                Name = banner.Name,
                Status = banner.Status,
                SortOrder = banner.SortOrder,
                IsOutstanding = banner.IsOutstanding
            };
            return bannerViewModel;
        }
        public async Task<int> Update(BannerUpdateRequest request)//đổi <int> create => <Update> create
        {

            var banner = await _context.Banners.FindAsync(request.Id);

            if (banner == null)
                throw new CosmeticsException($"Cannot found banner width id: {request.Id}");

            if (request.ImageFile != null)
            {
                    banner.FileSize = request.ImageFile.Length;
                    banner.ImagePath = await SaveFile(request.ImageFile);
            }
            banner.Name = request.Name;
            banner.Description = request.Description;
            banner.IsOutstanding = request.IsOutstanding;
            _context.Banners.Update(banner);

            await _context.SaveChangesAsync();
            return 1 /*1 is success*/;
        }

        public async Task<bool?> Delete(int bannerId)
        {
            var banner = await _context.Banners.FindAsync(bannerId);
            if (banner == null)
            {
                return null;
            }

            await _storageService.DeleteFileAsync(banner.ImagePath);

            _context.Banners.Remove(banner);

            await _context.SaveChangesAsync();
            
            return true;

        }

        public async Task<PageResponse<BannerViewModel>> GetAllPaging(PaginateRequest request)
        {
            int PageIndex = request.PageIndex;
            int PageSize = request.PageSize;
            var totalRecords = 0;
            var query = from b in _context.Banners select b;

            if (request.Keyword != null)
            {
                query = query.Where(x => x.Name.Contains(request.Keyword));
            }
            totalRecords = await query.CountAsync();

            var data = await query
                .Select(x => new BannerViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    DateCreated = x.DateCreated,
                    FileSize = x.FileSize,
                    ImagePath = x.ImagePath,
                    IsDefault = x.IsDefault,
                    SortOrder = x.SortOrder,
                    IsOutstanding = x.IsOutstanding,
                    Status = x.Status
                }).Skip((PageIndex - 1) * PageSize)
                .Take(PageSize).ToListAsync();
            var response = new PageResponse<BannerViewModel>()
            {
                Items = data,
                TotalRecords = totalRecords,
                PageIndex = PageIndex,
                PageSize = PageSize
            };
            return response;
        }


    }

    
}
