using Cosmetics.ViewModels.Catalogs.Orders;
using Cosmetics.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<bool>> ClientCancelOrder(int orderId, string cancelReason)
        {
            var client = GetClient();
            var token = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var json = JsonConvert.SerializeObject(new ClientCancelOrderReasonRequest() { Message = cancelReason });
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var url = $"/api/orders/{orderId}/cancel";
            var response = await client.PutAsync(url, httpContent);

            var resultJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResult<bool>>(resultJson);
        }

        public async Task<int> ClientCreateOrder(ClientCreateOrderViewModel request)
        {

            string url = "/api/orders/client";
            var result = await PostAsync<int, ClientCreateOrderViewModel>(url, request);

            return result;
        }

        public async Task<ApiResult<ClientOrderViewModel>> GetOrder(Guid cartId, int orderId)
        {
            string url = $"/api/orders/client/{cartId}/order/{orderId}";
            var result = await GetAsync<ApiResult<ClientOrderViewModel>>(url);
            return result;
        }

        public async Task<PageResponse<ClientOrderHistoryViewMode>> GetOrderHistory(Guid clientId ,GetOrderRequest request,string status)
        {
            var requestUrl = $"/api/orders/{clientId}/paging?pageIndex=" +
               $"{request.PageIndex}&pageSize={request.PageSize}&Status={status}&DateStart={request.DateStart}&DateEnd={request.DateEnd}";
            var data = await GetAsync<PageResponse<ClientOrderHistoryViewMode>>(requestUrl);
            return data;
        }
    }
}
