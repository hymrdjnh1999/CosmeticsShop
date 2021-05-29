﻿using Cosmetics.ViewModels.Common;
using Cosmetics.ViewModels.Systems.Clients;
using CosmeticsShop.Data.Entities;
using CosmeticsShop.Data.EntityFrameWork;
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

namespace CosmeticsShop.Application.Systems.Clients
{
    public class ClientService : IClientService
    {
        private readonly CosmeticsDbContext _context;
        private readonly IConfiguration _config;
        public ClientService(CosmeticsDbContext context, IConfiguration configuration)
        {
            _context = context;
            _config = configuration;
        }

        public async Task<ApiResult<string>> Login(ClientLoginRequest request)
        {
            var client = await _context.Clients.Where(x => x.Email == request.Email).FirstOrDefaultAsync();
            if (client == null)
            {
                return new ApiErrorResult<string>("Tài khoản không tồn tại");
            }
            var hasher = new PasswordHasher<Client>();
            var isCorrectPassword = hasher.VerifyHashedPassword(client, client.Password, request.Password);
            if (isCorrectPassword != PasswordVerificationResult.Success)
            {
                return new ApiErrorResult<string>("Tài khoản hoặc mật khẩu khoogn chính xác");
            }
            try
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Email,request.Email),
                    new Claim(ClaimTypes.Name,client.Name),
                    new Claim("Id",client.Id.ToString())
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                    _config["Tokens:Issuer"],
                    claims,
                    expires: DateTime.Now.AddHours(24),
                    signingCredentials: creds);
                return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
            }
            catch (Exception)
            {
                return new ApiErrorResult<string>("Lỗi đăng nhập");
            }
        }

        public async Task<ApiResult<string>> Register(ClientRegisterRequest request)
        {
            var client = await _context.Clients.Where(x => x.Email == request.Email).FirstOrDefaultAsync();
            var user = await _context.Users.Where(x => x.Email == request.Email).FirstOrDefaultAsync();
            if (client != null || user != null)
            {
                return new ApiErrorResult<string>("Email đã tồn tại");
            }
            var hashser = new PasswordHasher<Client>();
            var newClient = new Client()
            {
                Email = request.Email,
                Name = request.FullName,
                Password = hashser.HashPassword(null, request.Password),
            };
            _context.Clients.Add(newClient);
            await _context.SaveChangesAsync();

            try
            {
                var claims = new[]
                {
                new Claim(ClaimTypes.Email,newClient.Email),
                new Claim(ClaimTypes.Name,newClient.Name),
                new Claim("Id",newClient.Id.ToString())
            };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                    _config["Tokens:Issuer"],
                    claims,
                    expires: DateTime.Now.AddHours(24),
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

                return new ApiErrorResult<string>("Liên hệ quản lý");
            }
        }
    }
}