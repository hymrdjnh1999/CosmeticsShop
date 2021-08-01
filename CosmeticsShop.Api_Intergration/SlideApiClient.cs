using Cosmetics.ViewModels.Ultilities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CosmeticsShop.Api_Intergration
{
    public class SlideApiClient : BaseApiClient, ISlideApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public SlideApiClient(IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor, configuration)
        {

        }

        public async Task<List<SlideViewModel>> GetAll()
        {
            return await GetAsync<List<SlideViewModel>>("/api/slides");
        }
    }
}
