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
        public async Task<int> ClientCreateOrder(ClientCreateOrderViewModel request)
        {

            string url = "/api/orders/client";
            var result = await PostAsync<int, ClientCreateOrderViewModel>(url, request);

            return result;
        }

        public async Task<ClientOrderViewModel> GetOrder(Guid cartId, int orderId)
        {
            string url = $"/api/orders/client/{cartId}/{orderId}";
            var result = await GetAsync<ClientOrderViewModel>(url);
            return result;
        }
    }
}
