﻿using Cosmetics.ViewModels.Catalogs.Banners;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public class BannerApiClient : IBannerApiClient
    {
        public Task<int> Create(BannerCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Edit(BannerUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<BannerViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PageResponse<BannerViewModel>> GetAllPaging(PaginateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<BannerViewModel> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
