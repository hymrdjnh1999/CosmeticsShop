using Cosmetics.ViewModels.Catalogs.Banners;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Application.Catalog.Banners;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : Controller
    {
        private readonly IBannerService _bannerService;

        public BannersController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        [HttpPost("banner/create")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] BannerCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var bannerId = await _bannerService.Create(request);
            if (bannerId < 0)
            {
                return BadRequest();
            }

            var banner = await _bannerService.GetById(bannerId);
            banner.Id = bannerId;

            return CreatedAtAction(nameof(GetById), new { Id = bannerId }, bannerId);
        }
        [Authorize]
        [HttpGet("paging")]
        public async Task<IActionResult> Index([FromQuery] GetBannerPagingRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var banners = await _bannerService.GetAllPaging(request);
            return Ok(banners);
        }
        /*public async Task<IActionResult> Index([FromQuery] GetBannerRequest request)
        {
            if (!ModelState.IsValid || request.PageSize <= 0)
            {
                return Ok(new PageResponse<BannerViewModel>() { Items = new List<BannerViewModel>(), PageIndex = 1, PageSize = 5, TotalRecords = 0 });
            }

            var banners = await _bannerService.GetAll(request);
            return Ok(banners);
        }*/
        /*[HttpGet("paging")]
        public async Task<IActionResult> Get([FromQuery] GetBannerRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var banners = await _bannerService.GetAll(request);
            return Ok(banners);
        }*/
        [HttpGet("{id}")]
        [Authorize]

        public async Task<IActionResult> GetById(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var banner = await _bannerService.GetById(id);
            if (banner == null)
            {
                return BadRequest($"không tìm thấy id: {id}");
            }

            return Ok(banner);
        }
    }
}
