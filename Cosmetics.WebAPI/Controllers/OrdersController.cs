﻿using Cosmetics.ViewModels.Catalogs.Orders;
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

    }
}
