using Cosmetics.ViewModels.Catalogs.Orders;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public interface IOrderApiClient
    {
        Task<PageResponse<OrderViewModel>> GetAll(GetOrderRequest request);
    }
}
