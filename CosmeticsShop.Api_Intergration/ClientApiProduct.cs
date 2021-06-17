using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public class ClientApiProduct : BaseApiClient, IClientApiProduct
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _config;
        private readonly IHttpClientFactory _httpClientFactory;
        public ClientApiProduct(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) : base(httpClientFactory, httpContextAccessor, configuration)
        {

        }
        public async Task<ApiResult<ClientProductViewModel>> GetProuctDetail(int id)
        {
            var url = $"/api/products/{id}/client";
            var response = await GetAsync<ApiResult<ClientProductViewModel>>(url);
            return response;
        }
    }
}
