using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public interface IClientApiProduct
    {
        Task<ApiResult<ClientProductViewModel>> GetProuctDetail(int id);
    }
}
