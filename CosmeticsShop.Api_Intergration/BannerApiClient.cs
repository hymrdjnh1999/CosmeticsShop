using Cosmetics.Ultilities.Constants;
using Cosmetics.ViewModels.Catalogs.Banners;
using Cosmetics.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public class BannerApiClient : BaseApiClient, IBannerApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public BannerApiClient(IHttpClientFactory httpClientFactory,
          IConfiguration configuration,
          IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }
        public async Task<bool> Create(BannerCreateRequest request)
        {
            var sessions = _httpContextAccessor
               .HttpContext
               .Session
               .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();
            if (request.ImageFile != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.ImageFile.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.ImageFile.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "imageFile", request.ImageFile.FileName);
            }
            
            var nameJs = new StringContent(request.Name.ToString());
            requestContent.Add(nameJs, "name");
            var descriptionJs = new StringContent((request.Description ?? "").ToString());
            requestContent.Add(descriptionJs, "description");


            var response = await client.PostAsync($"/api/banners/create", requestContent);
            if (response.IsSuccessStatusCode)
                return true;

            return false;

        }

        public async Task<bool> Delete(int id)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.DeleteAsync($"/api/banners/{id}");

            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<bool> Edit(BannerUpdateRequest request)
        {
            var sessions = _httpContextAccessor
             .HttpContext
             .Session
             .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();

            var nameJs = new StringContent(request.Name.ToString());
            requestContent.Add(nameJs, "name");

            if (request.ImageFile != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.ImageFile.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.ImageFile.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "imageFile", request.ImageFile.FileName);
            }
            
            var descriptionJs = new StringContent((request.Description ?? "").ToString());
            requestContent.Add(descriptionJs, "description");


            var response = await client.PutAsync($"/api/banners/{request.Id}", requestContent);

            return response.IsSuccessStatusCode;
        }

        public async Task<List<BannerViewModel>> GetAll()
        {
            var banners = await GetAsync<List<BannerViewModel>>("/api/banners");
            return banners;
        }

        public async Task<PageResponse<BannerViewModel>> GetAllPaging(PaginateRequest request)
        {
            
            var requestUrl = $"/api/banners/paging?pageIndex=" +
              $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}";
            var banners = await GetAsync<PageResponse<BannerViewModel>>(requestUrl);
            return banners;
        }

        public async Task<BannerUpdateRequest> GetById(int id)
        {
            var requestUrl = $"/api/banners/{id}";

            var banner = await GetAsync<BannerUpdateRequest>(requestUrl);

            return banner;
        }
    }
}
