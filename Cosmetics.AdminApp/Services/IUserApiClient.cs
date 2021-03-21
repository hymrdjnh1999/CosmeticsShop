using Cosmetics.ViewModels.Common;
using Cosmetics.ViewModels.Systems.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PageResponse<UserViewModel>> GetUserPaging(GetUserPagingRequest request);

        Task<bool> RegisterUser(RegisterRequest request);
    }
}
