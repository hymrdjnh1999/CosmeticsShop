﻿using Cosmetics.ViewModels.Common;
using Cosmetics.ViewModels.Systems.Users;
using CosmeticsShop.Data.Entities;
using CosmeticsShop.Data.EntityFrameWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Application.Systems.Users
{
    public class UserService : IUserService
    {


        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _config;
        private readonly CosmeticsDbContext _context;
        public UserService(UserManager<User> userMananger,
            SignInManager<User> signInManaager,
            RoleManager<Role> roleManager,
            IConfiguration config,
            IHttpContextAccessor httpContextAccessor,
            CosmeticsDbContext context
            )
        {
            _userManager = userMananger;
            _signInManager = signInManaager;
            _roleManager = roleManager;
            _config = config;
            _context = context;
        }

        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {

            try
            {
                var user = await _context.Users.Where(x => request.UserName == x.UserName).SingleOrDefaultAsync();
                if (user == null) return new ApiErrorResult<string>("User is not exists!");

                var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
                if (!result.Succeeded)
                {
                    return new ApiErrorResult<string>("Password is wrong!");
                }

                var roles = await _userManager.GetRolesAsync(user);
                var claims = new[]
                {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.Name),
                new Claim("Role",string.Join(";",roles)),
                new Claim(ClaimTypes.Name,user.Name),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
            };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                    _config["Tokens:Issuer"],
                    claims,
                    expires: DateTime.Now.AddHours(3),
                    signingCredentials: creds);

                var apiResult = new ApiResult<string>()
                {
                    IsSuccess = true,
                    ResultObj = new JwtSecurityTokenHandler().WriteToken(token)
                };
                return apiResult;
            }
            catch (Exception)
            {

                return new ApiErrorResult<string>("Lỗi đăng nhập");
            }


        }

        public async Task<ApiResult<bool>> Delete(Guid id)
        {

            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                return new ApiErrorResult<bool>("User is not exists!");

            var result = await _userManager.DeleteAsync(user);

            if (!result.Succeeded)
            {
                return new ApiErrorResult<bool>();
            }
            return new ApiSuccessResult<bool>();


        }

        public async Task<ApiResult<UserViewModel>> GetById(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                return new ApiErrorResult<UserViewModel>("User is not exists!");

            var roles = await _userManager.GetRolesAsync(user);

            var userViewModel = new UserViewModel()
            {
                Dob = user.Dob,
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName,
                Roles = roles
            };

            return new ApiSuccessResult<UserViewModel>(userViewModel);
        }

        public async Task<ApiResult<PageResponse<UserViewModel>>> GetUserPaging(GetUserPagingRequest request)
        {
            var query = _userManager.Users;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UserName.Contains(request.Keyword)
                || x.PhoneNumber.Contains(request.Keyword)
                || x.Email.Contains(request.Keyword));
            }
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new UserViewModel()
                {
                    Dob = x.Dob,
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber,
                    Id = x.Id,
                    Name = x.Name,
                    UserName = x.UserName
                }).ToListAsync();

            var pageResponse = new PageResponse<UserViewModel>()
            {
                Items = data,
                TotalRecords = totalRow,
                PageIndex = (request.PageIndex - 1) * request.PageSize,
                PageSize = request.PageSize,
            };

            var apiResult = new ApiSuccessResult<PageResponse<UserViewModel>>(pageResponse);


            return apiResult;

        }

        public async Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);


            if (user != null)
                return new ApiErrorResult<bool>("Tài khoản đã tồn tại!");

            user = await _userManager.FindByEmailAsync(request.Email);

            if (user != null)
                return new ApiErrorResult<bool>("Email đã tồn tại!");

            var hasher = new PasswordHasher<User>();
            user = new User()
            {
                Dob = request.Dob,
                Name = request.Name,
                Email = request.Email,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
            };

            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                user.PasswordHash = hasher.HashPassword(user, request.Password);
                _context.Users.Attach(user);
                await _context.SaveChangesAsync();
                var role = await _context.Roles.Where(x => x.Name == "Staff").FirstOrDefaultAsync();
                var userRole = new IdentityUserRole<Guid>()
                {
                    RoleId = role.Id,
                    UserId = user.Id
                };
                _context.UserRoles.Add(userRole);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return new ApiErrorResult<bool>("Có lỗi trong quá trình tạo tài khoàn");
            }
            return new ApiSuccessResult<bool>();
        }

        public async Task<ApiResult<bool>> RoleAssign(RoleAssignRequest request)
        {
            var user = await _userManager.FindByIdAsync(request.Id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<bool>("User is not exists");
            }
            var userRolesIds = await _context.UserRoles.Where(x => x.UserId == request.Id).Select(x=>x.RoleId).ToListAsync();
            var roles = await _context.Roles.Where(x => userRolesIds.Contains(x.Id)).ToListAsync();

            if (request.Roles != null)
            {
                foreach (var role in request.Roles)
                {
                    if (role.Selected && !userRolesIds.Contains(role.Id))
                    {
                        _context.UserRoles.Add(new IdentityUserRole<Guid>
                        {
                            RoleId = role.Id,
                            UserId = user.Id
                        });

                    }
                    else if (!role.Selected || userRolesIds.Contains(role.Id))
                    {
                        var userRole = await _context.UserRoles.Where(x => x.RoleId == role.Id && x.UserId == user.Id).FirstOrDefaultAsync();
                        if(userRole != null)
                        _context.UserRoles.Remove(userRole);
                    }
                    await _context.SaveChangesAsync();


                }
            }

            return new ApiSuccessResult<bool>();
        }

        public async Task<ApiResult<bool>> Update(Guid id, UserViewModel request)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            user.Dob = request.Dob;
            user.Name = request.Name;
            user.PhoneNumber = request.PhoneNumber;

            try
            {
                _context.Users.Attach(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                return new ApiErrorResult<bool>("Update is not success!");
            }
           
            return new ApiSuccessResult<bool>();

        }
    }
}
