using Cosmetics.ViewModels.Catalogs.Orders;
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
    }
}
