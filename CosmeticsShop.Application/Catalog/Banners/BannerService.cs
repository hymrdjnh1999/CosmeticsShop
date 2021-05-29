using Cosmetics.ViewModels.Catalogs.Banners;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Banners
{
    class BannerService : IBannerService
    {
        public Task<int> Create(BannerCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int bannerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<BannerViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }


        public Task<PageResponse<BannerViewModel>> GetAllPaging(string bannerId, QueryParamRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<BannerViewModel> GetById()
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(BannerUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
