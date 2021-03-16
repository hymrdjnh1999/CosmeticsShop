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
            var products = await _publicProductService.GetAll(request);
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
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
            var deleted = await _manangeProductService.Delete(id);
            if (deleted == null)
            {
                return BadRequest($"Không tồn tại id: {id}");
            }

            return Ok("Deleted");
        }

        [HttpPut("{id}/price")]
        public async Task<IActionResult> UpdatePrice([FromBody] decimal newPrice, int id)
        {
            var result = await _manangeProductService.UpdatePrice(id, newPrice);
            if (!result)
            {
                return BadRequest();
            }

            return Ok("Updated");
        }

    }
}
