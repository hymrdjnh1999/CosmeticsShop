using Cosmetics.ViewModels.Common;
using Cosmetics.ViewModels.Systems.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Systems.Clients
{
    public interface IClientService
    {
        Task<ApiResult<string>> Register(ClientRegisterRequest request);
        Task<ApiResult<string>> Login(ClientLoginRequest request);
    }
}
