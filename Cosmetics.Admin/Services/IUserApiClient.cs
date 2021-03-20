using Cosmetics.ViewModels.Systems.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.Admin.Services
{
    public interface IUserApiClient
    {
        Task<string> Aithenticate(LoginRequest request);
    }
}
