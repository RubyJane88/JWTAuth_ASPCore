﻿using System;
using System.Threading.Tasks;
using JWTAuth_ASPCore.Models;

namespace JWTAuth_ASPCore.Services
{
    public interface IUserService
    {
        Task<string> Register(RegisterModel model);
        Task<string> RegisterAsync(RegisterModel model);
        Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
