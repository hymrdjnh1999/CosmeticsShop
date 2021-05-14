using Cosmetics.ViewModels.Catalogs.Orders;
using CosmeticsShop.Application.Catalog.Orders;
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
    public class OrdersController : Controller
    {
        private IOrderService _orderService;
        public OrdersController(IOrderService orderSerive)
        {
            _orderService = orderSerive;
        }
        [HttpGet("paging")]
        [Authorize]

        public async Task<IActionResult> Index([FromQuery] GetOrderRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var products = await _orderService.GetAll(request);
            return Ok(products);
        }
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{

        //}
    }
}
