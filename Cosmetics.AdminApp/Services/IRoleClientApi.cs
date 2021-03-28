using Cosmetics.ViewModels.Common;
using Cosmetics.ViewModels.Systems.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.AdminApp.Services
{
    public interface IRoleClientApi
    {
        Task<ApiResult<List<RoleViewModel>>> GetAll();
    }
}
