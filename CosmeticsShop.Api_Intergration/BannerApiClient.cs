using Cosmetics.Ultilities.Constants;
using Cosmetics.ViewModels.Catalogs.Banners;
using Cosmetics.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
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
    public class BannerApiClient : BaseApiClient,IBannerApiClient
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

            var contentJs = new StringContent((request.Description ?? "").ToString());
            requestContent.Add(contentJs, "description");


            var response = await client.PostAsync($"/api/banners/{request.BannerId}", requestContent);
            if (response.IsSuccessStatusCode)
            {return true;

            }
                

            return false;

        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Edit(BannerUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BannerViewModel>> GetAll()
        {
            var banners = await GetAsync<List<BannerViewModel>>("/api/banner");
            return banners;
        }

        public async Task<PageResponse<BannerViewModel>> GetAllPaging(PaginateRequest request)
        {
            var requestUrl = $"/api/products/banner/pageSize={request.PageSize}&pageIndex={request.PageIndex}";
            var data = await GetAsync<PageResponse<BannerViewModel>>(requestUrl);
            return data;
        }

        public Task<BannerViewModel> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
