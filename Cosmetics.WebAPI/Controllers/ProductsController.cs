using Cosmetics.ViewModels.Catalogs.ProductImages;
using Cosmetics.ViewModels.Catalogs.Products;
using Cosmetics.ViewModels.Catalogs.Products.Manage;
using Cosmetics.ViewModels.Catalogs.Products.Public;
using Cosmetics.ViewModels.Common;
using CosmeticsShop.Application.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manangeProductService;
        public ProductsController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manangeProductService = manageProductService;
        }




        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] PublicPagingRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var products = await _publicProductService.GetAll(request);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var product = await _manangeProductService.GetById(id);
            if (product == null)
            {
                return BadRequest($"Không tồn tại sản phẩm có id: {id}");
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var productId = await _manangeProductService.Create(request);
            if (productId == 0)
            {
                return BadRequest();
            }

            var product = await _manangeProductService.GetById(productId);

            return CreatedAtAction(nameof(GetById), new { Id = productId }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var affectedResult = await _manangeProductService.Update(request);
            if (affectedResult == 0)
            {
                return BadRequest();
            }

            return Ok("Updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var deleted = await _manangeProductService.Delete(id);
            if (deleted == null)
            {
                return BadRequest($"Không tồn tại id: {id}");
            }

            return Ok("Deleted");
        }

        [HttpPatch("{id}/price")]
        public async Task<IActionResult> UpdatePrice([FromBody] decimal newPrice, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _manangeProductService.UpdatePrice(id, newPrice) ?? false;
            if (!result)
            {
                return BadRequest();
            }

            return Ok("Updated");
        }

        // Product Images

        [HttpGet("{productId}/images/{id}")]
        public async Task<IActionResult> GetByImageId(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var image = await _manangeProductService.GetImageById(id);
            if (image == null)
            {
                return BadRequest($"Không tồn tại sản phẩm có id: {id}");
            }

            return Ok(image);
        }

        [HttpPut("{productId}/images/{id}")]
        public async Task<IActionResult> UpdateImage(int id, [FromForm] ProductImageUpdateRequest request)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var affectedResult = await _manangeProductService.UpdateImage(id, request);
            if (affectedResult == 0)
            {
                return BadRequest();
            }

            return Ok("Updated");
        }

        [HttpPost("{productId}/{id}/images")]
        public async Task<IActionResult> AddImage(int id, [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var imageId = await _manangeProductService.AddImage(id, request);
            if (imageId < 1)
            {
                return BadRequest();
            }

            var image = await _manangeProductService.GetImageById(imageId);

            return CreatedAtAction(nameof(GetByImageId), new { Id = imageId }, image);
        }

        [HttpDelete("{productId}/images/{id}")]
        public async Task<IActionResult> DeleteImage(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var deleted = await _manangeProductService.RemoveImage(id);
            if (deleted == 0)
            {
                return BadRequest();
            }

            return Ok("Deleted");
        }

    }
}
