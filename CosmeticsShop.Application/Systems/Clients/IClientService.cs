using Cosmetics.ViewModels.Catalogs.Orders;
using Cosmetics.ViewModels.Common;
using Cosmetics.ViewModels.Systems.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Systems.Clients
{
    public interface IClientService
    {
        Task<ApiResult<string>> Register(ClientRegisterRequest request);
        Task<ApiResult<string>> Login(ClientLoginRequest request);
        Task<ApiResult<ClientUpdateViewModel>> GetDetail(Guid clientId);
        Task<ApiResult<ClientUpdateViewModel>> Update(ClientUpdateViewModel request);
        Task<ApiResult<PageResponse<ClientViewModel>>> GetClientPaging(GetClientPagingRequest request);
        Task<ClientViewModel> GetClientById(Guid id);
        Task<List<OrderViewModel>> GetOrderByClient(Guid id);

    }
}