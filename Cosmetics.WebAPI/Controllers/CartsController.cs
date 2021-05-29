using Cosmetics.ViewModels.Catalogs.Carts;
using CosmeticsShop.Application.Catalog.Carts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmetics.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : Controller
    {
        private readonly ICartService _cartService;
        public CartsController(ICartService cartService)
        {
            _cartService = cartService;
        }
        [HttpPost("AddToCart")]
        public async Task<IActionResult> AddToCart(ClientCartViewModel request)
        {
            var result = await _cartService.AddToCart(request);
            return Ok(result);
        }
    }
}
