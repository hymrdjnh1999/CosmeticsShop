using Cosmetics.ViewModels.Catalogs.Orders;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public interface IClientOrderApi
    {
        Task<int> ClientCreateOrder(ClientCreateOrderViewModel request);
        Task<ApiResult<ClientOrderViewModel>> GetOrder(Guid cartId, int orderId);
        Task<List<ClientOrderHistoryViewMode>> GetOrderHistory(Guid clientId);

        Task<ApiResult<bool>> ClientCancelOrder(int orderId, string cancelReason);
    }
}
