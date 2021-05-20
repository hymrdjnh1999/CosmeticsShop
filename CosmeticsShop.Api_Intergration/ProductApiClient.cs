using Cosmetics.Ultilities.Constants;
using Cosmetics.ViewModels.Catalogs.ProductImages;
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

        public async Task<bool> AddImage(ProductImageCreateRequest request)
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

            var contentJs = new StringContent((request.Caption ?? "").ToString());
            requestContent.Add(contentJs, "caption");


            var response = await client.PostAsync($"/api/products/{request.ProductId}/images", requestContent);
            if (response.IsSuccessStatusCode)
                return true;

            return false;

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

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }

        public async Task<bool> ChangeThumbnail(int imageId, int productId)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.PutAsync($"/api/products/{productId}/images/{imageId}/thumbnail", null);

            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<ProductUpdateRequest> Create(ProductCreateRequest request)
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
            var descriptionJs = new StringContent((request.Description ?? "").ToString());
            requestContent.Add(descriptionJs, "description");
            var detailsJs = new StringContent((request.Details ?? "").ToString());
            requestContent.Add(detailsJs, "details");
            var originalCountryJs = new StringContent(request.OriginalCountry.ToString());
            requestContent.Add(originalCountryJs, "originalCountry");
            var originNalPriceJs = new StringContent(request.OriginalPrice.ToString());
            requestContent.Add(originNalPriceJs, "originalPrice");
            var forGenderJs = new StringContent(
                (request.ForGender == ForGender.Male ? 1 : request.ForGender == ForGender.Female ? 2 : 3).ToString());
            requestContent.Add(forGenderJs, "forgender");
            var response = await client.PostAsync($"/api/products", requestContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var product = JsonConvert.DeserializeObject<ProductUpdateRequest>(result);
                return product;
            }

            return null;
        }

        public async Task<bool> Delete(int product_id)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.DeleteAsync($"/api/products/{product_id}");

            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<ProductUpdateRequest> GetById(int id)
        {
            var requestUrl = $"/api/products/{id}";

            var response = await GetAsync<ProductUpdateRequest>(requestUrl);

            return response;
        }

        public async Task<ProductImageViewModel> GetImageById(int productId, int imageId)
        {
            var requestUrl = $"/api/products/{productId}/images/{imageId}";

            var image = await GetAsync<ProductImageViewModel>(requestUrl);

            return image;
        }





        public async Task<PageResponse<ProductViewModel>> GetPaging(GetProductRequest request)
        {
            var requestUrl = $"/api/products/paging?pageIndex=" +
               $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}&categoryId={request.CategoryId}";

            var data = await GetAsync<PageResponse<ProductViewModel>>(requestUrl);

            return data;
        }

        public async Task<PageResponse<ProductImageViewModel>> GetProductImages(int productId, QueryParamRequest request)
        {

            var requestUrl = $"/api/products/{productId}/images?pageSize={request.PageSize}&pageIndex={request.PageIndex}";
            var data = await GetAsync<PageResponse<ProductImageViewModel>>(requestUrl);
            return data;
        }

        public async Task<bool> Update(ProductUpdateRequest request)
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

            requestContent.Add(new StringContent((request.Name ?? "").ToString()), "name");

            requestContent.Add(new StringContent((request.Description ?? "").ToString()), "description");

            requestContent.Add(new StringContent((request.Details ?? "").ToString()), "details");

            requestContent.Add(new StringContent((request.OriginalCountry ?? "").ToString()), "originalCountry");

            requestContent.Add(new StringContent(
                (request.ForGender == ForGender.Male ? 1 : request.ForGender == ForGender.Female ? 2 : 3).ToString()), "forgender");

            requestContent.Add(new StringContent(request.Id.ToString()), "id");

            requestContent.Add(new StringContent(request.OriginalPrice.ToString()), "originalPrice");

            requestContent.Add(new StringContent(request.Price.ToString()), "Price");

            requestContent.Add(new StringContent(request.Stock.ToString()), "Stock");
            requestContent.Add(new StringContent(request.SelectedId.ToString()), "SelectedId");

            var response = await client.PutAsync($"/api/products/{request.Id}", requestContent);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateProductImage(ProductImageUpdateRequest request)
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

            var contentJs = new StringContent((request.Caption ?? "").ToString());
            requestContent.Add(contentJs, "caption");


            var response = await client.PutAsync($"/api/products/images/{request.Id}", requestContent);
            if (response.IsSuccessStatusCode)
                return true;

            return false;
        }

        public async Task<ApiResult<bool>> DeleteImage(int productId, int imageId)
        {
            var sessions = _httpContextAccessor
             .HttpContext
             .Session
             .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var response = await client.DeleteAsync($"/api/products/{productId}/images/{imageId}");
            var result = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result); ;
            }
            return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

        }
    }
}
