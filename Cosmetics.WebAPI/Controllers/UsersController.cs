using Cosmetics.ViewModels.Systems.Users;
using CosmeticsShop.Application.Systems.Users;
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
    [Authorize]

    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var loginToken = await _userService.Authenticate(request);
            if (string.IsNullOrEmpty(loginToken))
            {
                return BadRequest("Sai tài khoản hoặc mật khẩu");
            }
            return Ok(loginToken);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromForm] RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var registerResult = await _userService.Register(request);
            if (!registerResult)
            {
                return BadRequest("Đăng ký không thành công");
            }
            return Ok();
        }


        [HttpGet("paging")]
        public async Task<IActionResult> Get([FromQuery] GetUserPagingRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var users = await _userService.GetUserPaging(request);
            return Ok(users);
        }
    }
}
