using Cosmetics.Ultilities.Constants;
using Cosmetics.ViewModels.Catalogs.Orders;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Data.Entities;
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
    public class OrderApiClient : BaseApiClient, IOrderApiClient
    {

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public OrderApiClient(IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }
        public async Task<PageResponse<OrderViewModel>> GetAll(GetOrderRequest request)
        {
            var requestUrl = $"/api/orders/paging?pageIndex=" +
               $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.KeyWord}";

            var data = await GetAsync<PageResponse<OrderViewModel>>(requestUrl);

            return data;
        }

        public async Task<OrderViewModel> GetById(int id)
        {
            var request = $"/api/orders/{id}";
            var data = await GetAsync<OrderViewModel>(request);
            return data;
        }

        public async Task<List<OrderProductViewModel>> GetProducts(int id)
        {
            var request = $"/api/orders/{id}/products";
            var data = await GetAsync<List<OrderProductViewModel>>(request);
            return data;
        }

        public async Task<bool> UpdateStatus(OrderViewModel request)
        {
            var url = $"/api/orders/status";
            var sessions = _httpContextAccessor
               .HttpContext
               .Session
               .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(url, httpContent);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;

        }
    }
}
