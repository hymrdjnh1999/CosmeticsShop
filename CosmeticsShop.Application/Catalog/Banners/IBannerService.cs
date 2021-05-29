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
        Task<int> Update(BannerUpdateRequest request);
        Task<int> Delete(int bannerId);
        Task<List<BannerViewModel>> GetAll();
        Task<BannerViewModel> GetById();
        Task<PageResponse<BannerViewModel>> GetAllPaging(string bannerId, QueryParamRequest request);

    }

    
}
