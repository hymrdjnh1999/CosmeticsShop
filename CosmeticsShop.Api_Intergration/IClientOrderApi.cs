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
        Task<bool> ClientCreateOrder(ClientCreateOrderViewModel request);
    }
}
