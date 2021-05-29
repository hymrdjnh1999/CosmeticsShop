using Cosmetics.ViewModels.Catalogs.Banners;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public interface IBannerApiClient
    {
        Task<List<BannerViewModel>> GetAll();

        Task<PageResponse<BannerViewModel>> GetAllPaging(PaginateRequest request);

        Task<int> Create(BannerCreateRequest request);
        Task<bool> Edit(BannerUpdateRequest request);
        Task<BannerViewModel> GetById(int id);
        Task<bool> Delete(int id);
    }
}
