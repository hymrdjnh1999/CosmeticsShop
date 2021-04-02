using Cosmetics.ViewModels.Common;
using Cosmetics.ViewModels.Systems.Users;
using CosmeticsShop.Api_Intergration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.AdminApp.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _config;
        IRoleClientApi _roleClientApi;
        public UserController(IUserApiClient userApiClient,
            IConfiguration config,
            IRoleClientApi roleClientApi)
        {
            _userApiClient = userApiClient;
            _config = config;
            _roleClientApi = roleClientApi;

        }


        public async Task<IActionResult> Index(string keyword = "", int pageIndex = 1, int pageSize = 10)
        {

            var request = new GetUserPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
            };

            var data = await _userApiClient.GetUserPaging(request);
            ViewBag.Keyword = keyword;
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data.ResultObj);
        }



        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return RedirectToAction("Index", "Login");
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _userApiClient.RegisterUser(request);
            if (result.IsSuccess)
            {
                TempData["result"] = "Create user successfully!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            return View(request);
        }



        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var result = await _userApiClient.GetById(id);

            if (result.IsSuccess)
            {
                return View(result.ResultObj);
            }

            return RedirectToAction("Error", "Home");

        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var result = await _userApiClient.GetById(id);
            var user = result.ResultObj;

            if (result.IsSuccess)
            {
                var updateUserModel = new UpdateUserRequest()
                {
                    Id = id,
                    Dob = user.Dob,
                    Name = user.Name,
                    PhoneNumber = user.PhoneNumber
                };
                return View(updateUserModel);
            }
            return RedirectToAction("Error", "Home");

        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateUserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _userApiClient.UpdateUser(request.Id, request);
            if (result.IsSuccess)
            {
                TempData["result"] = "Update user successfully!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);

            return View(request);
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var deleteModel = new DeleteUserRequest { Id = id };
            return View(deleteModel);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteUserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var result = await _userApiClient.Delete(request.Id);

            if (result.IsSuccess)
            {
                TempData["result"] = "Delete user successfully!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> RoleAssign(Guid id)
        {

            var roleAssignRequest = await GetRoleAssignRequest(id);

            return View(roleAssignRequest);

        }

        [HttpPost]
        public async Task<IActionResult> RoleAssign(RoleAssignRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _userApiClient.RoleAssign(request);

            if (result.IsSuccess)
            {
                TempData["result"] = "Role assign successfully";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.Message);
            var roleAssignRequest = await GetRoleAssignRequest(request.Id);

            return View(roleAssignRequest);
        }

        private async Task<RoleAssignRequest> GetRoleAssignRequest(Guid id)
        {
            var userObj = await _userApiClient.GetById(id);
            var roleObj = await _roleClientApi.GetAll();
            var roleAssignRequest = new RoleAssignRequest();
            foreach (var role in roleObj.ResultObj)
            {
                roleAssignRequest.Roles.Add(new SelectItem()
                {
                    Id = role.Id,
                    Name = role.Name,
                    Selected = userObj.ResultObj.Roles.Contains(role.Name)
                });
            }
            roleAssignRequest.Id = id;
            return roleAssignRequest;
        }

    }
}
