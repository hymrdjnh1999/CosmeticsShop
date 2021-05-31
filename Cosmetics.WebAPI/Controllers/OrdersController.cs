
using Cosmetics.ViewModels.Catalogs.Orders;
using Cosmetics.ViewModels.Common;
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
            if (!ModelState.IsValid || request.PageSize <= 0)
            {
                return Ok(new PageResponse<OrderViewModel>() { Items = new List<OrderViewModel>(), PageIndex = 1, PageSize = 5, TotalRecords = 0 });
            }

            var orders = await _orderService.GetAll(request);
            return Ok(orders);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest(id);
            }

            var order = await _orderService.GetById(id);
            if (order == null)
            {
                return BadRequest(id);
            }
            return Ok(order);
        }
        [HttpGet("{id}/products")]
        public async Task<IActionResult> GetOrderProducts(int id)
        {
            if (id <= 0)
            {
                return BadRequest(id);
            }
            var products = await _orderService.GetOrderProducts(id);
            return Ok(products);
        }

        [HttpPut("status")]
        public async Task<IActionResult> UpdateStatus(OrderViewModel request)
        {
            var result = await _orderService.UpdateStatus(request);
            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }
        [HttpPost("client")]
        public async Task<IActionResult> ClientCreateOrder(ClientCreateOrderViewModel request)
        {
            var result = await _orderService.ClientCreateOrder(request);
            return Ok(result);
        }
        [HttpGet("client/{cartId}/order/{orderId}")]
        public async Task<IActionResult> ClientGetOrder(Guid cartId, int orderId)
        {
            var result = await _orderService.ClientGetOrder(cartId, orderId);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}
