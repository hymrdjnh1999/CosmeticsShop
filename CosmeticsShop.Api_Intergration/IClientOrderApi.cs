using Cosmetics.ViewModels.Catalogs.Orders;
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
        Task<ClientOrderViewModel> GetOrder(Guid cartId, int orderId);
    }
}
