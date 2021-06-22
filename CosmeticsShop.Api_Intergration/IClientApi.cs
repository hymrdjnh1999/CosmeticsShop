using Cosmetics.ViewModels.Catalogs.Orders;
using Cosmetics.ViewModels.Common;
using Cosmetics.ViewModels.Systems.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public interface IClientApi
    {
        Task<ApiResult<string>> Login(ClientLoginRequest request);
        Task<ApiResult<string>> Register(ClientRegisterRequest request);
        Task<ApiResult<ClientUpdateViewModel>> GetDetail(Guid userId);
        Task<ApiResult<ClientUpdateViewModel>> Update(ClientUpdateViewModel request);
        Task<ApiResult<PageResponse<ClientViewModel>>> GetClientPaging(GetClientPagingRequest request);

        Task<ClientViewModel> GetByClientId(Guid clientid);
        Task<List<OrderViewModel>> GetOrderByClientId(Guid id);


    }
}
