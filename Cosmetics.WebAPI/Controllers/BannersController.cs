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
    public class BannersController : ControllerBase
    {
        private readonly IBannerService _bannerService;

        public BannersController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }
        /*[HttpPost("banner/create")]
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

            return CreatedAtAction("Create", banner);
        }*/
        [HttpPost]
        [Consumes("multipart/form-data")]
        [Authorize]
        public async Task<IActionResult> Create([FromForm] BannerCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bannerId = await _bannerService.Create(request);
            if (bannerId == 0)
            {
                return BadRequest();
            }

            var banner = await _bannerService.GetById(bannerId);
            banner.Id = bannerId;

            return CreatedAtAction("banners", banner);
        }
        [Authorize]
        [HttpGet("paging")]
        public async Task<IActionResult> Index([FromQuery] PaginateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var banners = await _bannerService.GetAllPaging(request);
            return Ok(banners);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var deleted = await _bannerService.Delete(id);
            if (deleted == null)
            {
                return BadRequest($"Không tồn tại id: {id}");
            }

            return Ok("Deleted");
        }

        [HttpPut("{id}")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Update([FromForm] BannerUpdateRequest request)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            //request.Id = bannerId;
            var affectedResult = await _bannerService.Update(request);
            if (affectedResult == 0)
            {
                return BadRequest();
            }

            return Ok("Updated");
        }

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
