using Cosmetics.ViewModels.Common;
using Cosmetics.ViewModels.Systems.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public interface IRoleClientApi
    {
        Task<ApiResult<List<RoleViewModel>>> GetAll();
    }
}
