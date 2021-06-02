using Cosmetics.ViewModels.Catalogs.Banners;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Banners
{
    public interface IBannerService
    {

        Task<int> Create(BannerCreateRequest request);
        Task<bool> Update(BannerUpdateRequest request);
        Task<bool?> Delete(int bannerId);
        Task<List<BannerViewModel>> GetAll();
        Task<BannerViewModel> GetById(int bannerId);
        Task<PageResponse<BannerViewModel>> GetAllPaging(PaginateRequest request);

    }

    
}
