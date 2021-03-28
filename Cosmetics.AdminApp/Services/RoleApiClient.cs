using Cosmetics.ViewModels.Common;
using Cosmetics.ViewModels.Systems.Roles;
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
    public class RoleApiClient : IRoleClientApi
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public RoleApiClient(IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }



        public async Task<ApiResult<List<RoleViewModel>>> GetAll()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            var bearerToken = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            var requestUrl = $"/api/roles";
            var response = await client.GetAsync(requestUrl);
            var body = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {

                List<RoleViewModel> roleViewModels = (List<RoleViewModel>)JsonConvert.DeserializeObject(body, typeof(List<RoleViewModel>));
                return new ApiSuccessResult<List<RoleViewModel>>(roleViewModels);
            }

            return JsonConvert.DeserializeObject<ApiErrorResult<List<RoleViewModel>>>(body);
        }
    }
}
