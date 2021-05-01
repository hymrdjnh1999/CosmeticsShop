
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Ultilities.Constants;
using Cosmetics.ViewModels.Catalogs.Categories;
using Cosmetics.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
namespace CosmeticsShop.Api_Intergration
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _config;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpClientFactory = httpClientFactory;
            _config = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<int> Create(CategoryCreateRequest request)
        {
            var sessions = _httpContextAccessor
               .HttpContext
               .Session
               .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_config[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"/api/categories", httpContent);

            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<int>(result);
            }

            return JsonConvert.DeserializeObject<int>(result);
        }

        public async Task<bool> Delete(int id)
        {
            var sessions = _httpContextAccessor
             .HttpContext
             .Session
             .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_config[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var response = await client.DeleteAsync($"/api/categories/{id}");

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;

        }

        public async Task<bool> Edit(CategoryUpdateRequest request)
        {
            var sessions = _httpContextAccessor
              .HttpContext
              .Session
              .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_config[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"/api/categories", httpContent);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            var categories = await GetAsync<List<CategoryViewModel>>("/api/categories");
            return categories;
        }

        public async Task<PageResponse<CategoryViewModel>> GetAllPaging(PaginateRequest request)
        {

            var requestUrl = $"/api/categories/paging?pageIndex=" +
              $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}";
            var categories = await GetAsync<PageResponse<CategoryViewModel>>(requestUrl);
            return categories;
        }

        public async Task<CategoryViewModel> GetById(int id)
        {
            var requestUrl = $"/api/categories/{id}";
            var category = await GetAsync<CategoryViewModel>(requestUrl);
            return category;
        }
    }
}
