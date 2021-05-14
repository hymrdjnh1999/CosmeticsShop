using Cosmetics.ViewModels.Catalogs.Orders;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Orders
{
    public interface IOrderService
    {
        Task<PageResponse<OrderViewModel>> GetAll(GetOrderRequest request);
        Task<OrderViewModel> GetById(int id);
    }
}
