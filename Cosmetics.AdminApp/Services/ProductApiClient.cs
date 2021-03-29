using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Cosmetics.AdminApp.Services
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public ProductApiClient(IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor, configuration)
        {

        }

        public async Task<PageResponse<ProductViewModel>> GetPaging(GetProductRequest request)
        {
            var requestUrl = $"/api/products/paging?pageIndex=" +
               $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}";

            var data = await GetAsync<PageResponse<ProductViewModel>>(requestUrl);


            return data;
        }


    }
}
