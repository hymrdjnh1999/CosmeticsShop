using Cosmetics.ViewModels.Catalogs.Orders;
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
    public class ClientOrderApi : BaseApiClient, IClientOrderApi
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public ClientOrderApi(IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor, configuration)
        {

        }
        public async Task<bool> ClientCreateOrder(ClientCreateOrderViewModel request)
        {

            string url = "/api/orders/client";
            var result = await PostAsync<bool, ClientCreateOrderViewModel>(url, request);

            return result;
        }
    }
}
