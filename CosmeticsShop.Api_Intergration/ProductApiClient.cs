﻿using Cosmetics.Ultilities.Constants;
using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Catalogs.Products.Manage;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Data.Enums;
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
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public ProductApiClient(IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        public async Task<ApiResult<bool>> CategoryAssign(CategoryAssignRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync($"/api/products/{request.Id}/categories", httpContent);
            var result = await response.Content.ReadAsStringAsync();
            var test = JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }
        public async Task<bool> Create(ProductCreateRequest request)
        {
            var sessions = _httpContextAccessor
                 .HttpContext
                 .Session
                 .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();
            if (request.ThumbnailImage != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.ThumbnailImage.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.ThumbnailImage.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "thumbnailImage", request.ThumbnailImage.FileName);
            }
            var contentJs = new StringContent(request.Price.ToString());
            requestContent.Add(contentJs, "price");
            var originJs = new StringContent(request.OriginalPrice.ToString());
            requestContent.Add(originJs, "originalPrice");
            var stockJs = new StringContent(request.Stock.ToString());
            requestContent.Add(stockJs, "stock");
            var nameJs = new StringContent(request.Name.ToString());
            requestContent.Add(nameJs, "name");
            var descriptionJs = new StringContent(request.Description.ToString());
            requestContent.Add(descriptionJs, "description");
            var detailsJs = new StringContent(request.Details.ToString());
            requestContent.Add(detailsJs, "details");
            var originalCountryJs = new StringContent(request.OriginalCountry.ToString());
            requestContent.Add(originalCountryJs, "originalCountry");
            var originNalPriceJs = new StringContent(request.OriginalPrice.ToString());
            requestContent.Add(originNalPriceJs, "originalPrice");
            var forGenderJs = new StringContent(
                (request.ForGender == ForGender.Male ? 1 : request.ForGender == ForGender.Female ? 2 : 3).ToString());
            requestContent.Add(forGenderJs, "forgender");

            var response = await client.PostAsync($"/api/products", requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<ProductViewModel> GetById(int id)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            var bearerToken = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            var requestUrl = $"/api/products/{id}";

            var response = await client.GetAsync(requestUrl);

            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ProductViewModel>(result);
            }

            return JsonConvert.DeserializeObject<ProductViewModel>(result);
        }

        public async Task<List<ProductViewModel>> GetFeaturedProducts()
        {
            var requestUrl = $"/api/products/featured";
            var data = await GetAsync<List<ProductViewModel>>(requestUrl);
            return data;

        }

        public async Task<PageResponse<ProductViewModel>> GetPaging(GetProductRequest request)
        {
            var requestUrl = $"/api/products/paging?pageIndex=" +
               $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}&categoryId={request.CategoryId}";

            var data = await GetAsync<PageResponse<ProductViewModel>>(requestUrl);

            return data;
        }


    }
}