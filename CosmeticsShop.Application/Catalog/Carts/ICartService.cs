using Cosmetics.ViewModels.Catalogs.Carts;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Catalog.Carts
{
    public interface ICartService
    {
        Task<ClientCartViewModel> AddToCart(ClientCartViewModel request);
        Task<ClientCartViewModel> UpdateCart(ClientCartViewModel request);
        Task<ApiResult<ClientCartViewModel>> GetClientCart(Guid id);
        Task<ApiResult<ClientCartViewModel>> RemoveProductInCart(DeleteProductInCartRequest request);
    }
}
