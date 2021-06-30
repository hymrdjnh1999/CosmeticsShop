using Cosmetics.ViewModels.Catalogs.Orders;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Orders
{
    public interface IOrderService
    {
        Task<PageResponse<OrderViewModel>> GetAll(GetOrderRequest request , string status);
        Task<OrderViewModel> GetById(int id);
        Task<bool> UpdateStatus(OrderViewModel request);
        Task<List<OrderProductViewModel>> GetOrderProducts(int orderId);
        Task<int> ClientCreateOrder(ClientCreateOrderViewModel request);
        Task<ApiResult<ClientOrderViewModel>> ClientGetOrder(Guid cartId, int orderId);
        Task<List<ClientOrderHistoryViewMode>> ClientGetOrderHistory(Guid clientId);
        Task<ApiResult<bool>> ClientCancelOrder(int orderId, string reason);
    }
}
