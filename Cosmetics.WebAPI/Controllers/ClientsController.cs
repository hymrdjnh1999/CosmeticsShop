using Cosmetics.ViewModels.Systems.Clients;
using CosmeticsShop.Application.Systems.Clients;
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

    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(ClientLoginRequest request)
        {
            var result = await _clientService.Login(request);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(ClientRegisterRequest request)
        {
            var result = await _clientService.Register(request);
            if (!result.IsSuccess)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpGet("{clientId}")]
        [Authorize]
        public async Task<IActionResult> GetDetail(Guid clientId)
        {
            var result = await _clientService.GetDetail(clientId);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPut("{clientId}")]
        [Authorize]
        public async Task<IActionResult> Update([FromForm]ClientUpdateViewModel request, Guid clientId)
        {

            var result = await _clientService.Update(request);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("paging")]
        public async Task<IActionResult> Get([FromQuery] GetClientPagingRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var clients = await _clientService.GetClientPaging(request);
            return Ok(clients);
        }
    }
}
