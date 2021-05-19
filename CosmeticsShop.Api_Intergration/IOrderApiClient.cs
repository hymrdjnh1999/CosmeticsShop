using Cosmetics.ViewModels.Catalogs.Orders;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Data.Entities;
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
        Task<OrderViewModel> GetById(int id);
        Task<bool> UpdateStatus(OrderViewModel request);

        Task<List<OrderProductViewModel>> GetProducts(int id);
    }
}
