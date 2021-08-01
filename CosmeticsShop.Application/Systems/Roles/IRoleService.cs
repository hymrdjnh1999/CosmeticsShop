using Cosmetics.ViewModels.Common;
using Cosmetics.ViewModels.Systems.Roles;
using Cosmetics.ViewModels.Systems.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Systems.Roles
{
    public interface IRoleService
    {
        Task<List<RoleViewModel>> GetAll();

    }
}
